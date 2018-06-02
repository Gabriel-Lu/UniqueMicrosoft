from flask import Flask
from premade_estimator import *

app = Flask(__name__)

classifier = dl_train()
@app.route('/<a>/<b>/<c>/<d>')
def eval(a,b,c,d):
	a = float(a)
	b = float(b)
	c = float(c)
	d = float(d)
	kind_id, reliability = dl_predict(classifier,a,b,c,d)
	return str(kind_id)+" "+str(reliability)
if __name__ == '__main__':
    app.run(host='0.0.0.0')