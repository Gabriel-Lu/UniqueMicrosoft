from django.shortcuts import render
# Create your views here.
#coding=utf-8
import hashlib
import json
from lxml import etree
from django.utils.encoding import smart_str
from django.views.decorators.csrf import csrf_exempt
from django.http import HttpResponse
from urllib import request 
 
WEIXIN_TOKEN = 'hacker'
@csrf_exempt
def index(request):
    if request.method == "GET":
        signature = request.GET.get("signature", None)
        timestamp = request.GET.get("timestamp", None)
        nonce = request.GET.get("nonce", None)
        echostr = request.GET.get("echostr", None)
        print(echostr)
        token = WEIXIN_TOKEN
        tmp_list = [token, timestamp, nonce]
        tmp_list.sort()
        tmp_str = "%s%s%s" % tuple(tmp_list)
        tmp_str = hashlib.sha1(tmp_str.encode()).hexdigest()
        if tmp_str == signature:
            return HttpResponse(echostr)
        else:
            return HttpResponse("weixin  index")
    else:
        othercontent = autoreply(request)
        return HttpResponse(othercontent)
#微信服务器推送消息是xml的，根据利用ElementTree来解析出的不同xml内容返回不同的回复信息，就实现了基本的自动回复功能了，也可以按照需求用其他的XML解析方法
import xml.etree.ElementTree as ET
from lxml import etree
from mywork.models import infos
def autoreply(request):
    try:
        webData = request.body
        xmlData = ET.fromstring(webData)

        msg_type = xmlData.find('MsgType').text
        ToUserName = xmlData.find('ToUserName').text
        FromUserName = xmlData.find('FromUserName').text
        CreateTime = xmlData.find('CreateTime').text
        MsgType = xmlData.find('MsgType').text
        MsgId = xmlData.find('MsgId').text
        MsgContent = xmlData.find('Content').text

        toUser = FromUserName
        fromUser = ToUserName

        if msg_type == 'text' and MsgContent.find("绑定 ")==0:
            the_list_results = infos.objects.all()
            if len(the_list_results) != 0:
                d1 = str(the_list_results[len(the_list_results)-1].airtem)
                d2 = str(the_list_results[len(the_list_results)-1].airhum)
                d3 = str(the_list_results[len(the_list_results)-1].oilhum)
                d4 = str(the_list_results[len(the_list_results)-1].light)
                just = ["特别适宜","适宜生长","情况一般","情况糟糕"]
                zhonglei, kexindu = eval()
                print(zhonglei)
                print(kexindu)
                the_content1 = "空气温度"+d1
                the_content2 = "空气湿度"+str(the_list_results[len(the_list_results)-1].airhum)
                the_content3 = "土壤湿度"+str(the_list_results[len(the_list_results)-1].oilhum)
                the_content4 = "光照强度"+str(the_list_results[len(the_list_results)-1].light)
            content = "您好,您查询的区域{0}情况如下\n\n".format(MsgContent[3:])+the_content1+the_content2+the_content3+the_content4+"\n\n神经网络评估当前环境: "+just[int(zhonglei)]+"\n评估可信度 "+kexindu
            #content = the_content1
            replyMsg = TextMsg(toUser, fromUser, content)
            print ("成功了!!!!!!!!!!!!!!!!!!!")
            print (replyMsg)
            return replyMsg.send()

        elif msg_type == 'image':
            content = "图片已收到,谢谢"
            replyMsg = TextMsg(toUser, fromUser, content)
            return replyMsg.send()
        elif msg_type == 'voice':
            content = "语音已收到,谢谢"
            replyMsg = TextMsg(toUser, fromUser, content)
            return replyMsg.send()
        elif msg_type == 'video':
            content = "视频已收到,谢谢"
            replyMsg = TextMsg(toUser, fromUser, content)
            return replyMsg.send()
        elif msg_type == 'shortvideo':
            content = "小视频已收到,谢谢"
            replyMsg = TextMsg(toUser, fromUser, content)
            return replyMsg.send()
        elif msg_type == 'location':
            content = "位置已收到,谢谢"
            replyMsg = TextMsg(toUser, fromUser, content)
            return replyMsg.send()
        else:
            msg_type == 'link'
            content = "链接已收到,谢谢"
            replyMsg = TextMsg(toUser, fromUser, content)
            return replyMsg.send()

    except Exception as Argment:
        return Argment

def eval():
    the_list_results = infos.objects.all()
    if len(the_list_results) != 0:
        d1 = str(the_list_results[len(the_list_results)-1].airtem)
        d2 = str(the_list_results[len(the_list_results)-1].airhum)
        d3 = str(the_list_results[len(the_list_results)-1].oilhum)
        d4 = str(the_list_results[len(the_list_results)-1].light)
        the_url = "http://139.198.18.176:81/{0}/{1}/{2}/{3}".format(d1,d2,d3,d4)
        x = request.urlopen(the_url).read().decode('utf-8')
        print(x)
        x = x.split(' ',1)
        print(x[0])
        print(x[1])
        return x[0],x[1]

class Msg(object):
    def __init__(self, xmlData):
        self.ToUserName = xmlData.find('ToUserName').text
        self.FromUserName = xmlData.find('FromUserName').text
        self.CreateTime = xmlData.find('CreateTime').text
        self.MsgType = xmlData.find('MsgType').text
        self.MsgId = xmlData.find('MsgId').text

import time
class TextMsg(Msg):
    def __init__(self, toUserName, fromUserName, content):
        self.__dict = dict()
        self.__dict['ToUserName'] = toUserName
        self.__dict['FromUserName'] = fromUserName
        self.__dict['CreateTime'] = int(time.time())
        self.__dict['Content'] = content

    def send(self):
        XmlForm = """
        <xml>
        <ToUserName><![CDATA[{ToUserName}]]></ToUserName>
        <FromUserName><![CDATA[{FromUserName}]]></FromUserName>
        <CreateTime>{CreateTime}</CreateTime>
        <MsgType><![CDATA[text]]></MsgType>
        <Content><![CDATA[{Content}]]></Content>
        </xml>
        """
        return XmlForm.format(**self.__dict)