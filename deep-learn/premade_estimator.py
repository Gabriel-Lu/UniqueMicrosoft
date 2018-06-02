from __future__ import absolute_import
from __future__ import division
from __future__ import print_function

import argparse
import pandas as pd
import tensorflow as tf


# 我们采集的数据包括空气温度、空气湿度、土壤湿度、光照强度
CSV_COLUMN_NAMES = ['airtem', 'airhum',
                    'oilhum', 'light', 'Species']

# 我们提供的分类结果包括a,b,c,d四种，代表从好到坏
SPECIES = ['a', 'b', 'c','d']

def train_input_fn(features, labels, batch_size):
    # 转换输入为训练需要的dataset
    dataset = tf.data.Dataset.from_tensor_slices((dict(features), labels))
    dataset = dataset.shuffle(1000).repeat().batch(batch_size)
    return dataset

def eval_input_fn(features, labels, batch_size):
    # 转换输入为评估需要的dataset
    features=dict(features)
    if labels is None:
        inputs = features
    else:
        inputs = (features, labels)
    dataset = tf.data.Dataset.from_tensor_slices(inputs)
    assert batch_size is not None, "batch_size must not be None"
    dataset = dataset.batch(batch_size)
    return dataset

def dl_train():
    #args = parser.parse_args(argv[1:])

    # 从csv表中读取数据
    train_path = './iris_training.csv'
    train = pd.read_csv(train_path, names=CSV_COLUMN_NAMES, header=0)
    train_x, train_y = train, train.pop('Species')

    # 用特征列描述输入
    my_feature_columns = []
    for key in train_x.keys():
        my_feature_columns.append(tf.feature_column.numeric_column(key=key))

    # 建立一个两个隐藏层的深度学习网络
    classifier = tf.estimator.DNNClassifier(
        feature_columns=my_feature_columns,
        hidden_units=[10, 10],
        n_classes=4)

    # 调用网络的训练方法进行训练.
    classifier.train(
        input_fn=lambda:train_input_fn(train_x, train_y,
                                                 100),
        steps=1000)
    
    # 返回训练号的分类器
    return classifier

def dl_predict(classifier,a,b,c,d):
    # 传入四个float型数据，返回预测的序号与置信度
    predict_x = {
        'airtem': [a],
        'airhum': [b],
        'oilhum': [c],
        'light': [d],
    }
    # 调用网络的预测方法进行预测
    predictions = classifier.predict(
        input_fn=lambda:eval_input_fn(predict_x,
                                                labels=None,
                                                batch_size=100))
    # 格式化显示
    template = ('\nPrediction is "{}" ({:.1f}%), SPECIES "{}"')
    for pred_dict, expec in zip(predictions, SPECIES):
        class_id = pred_dict['class_ids'][0]
        probability = pred_dict['probabilities'][class_id]
        print(template.format(SPECIES[class_id],
                              100 * probability, SPECIES[class_id]))
    return class_id,probability