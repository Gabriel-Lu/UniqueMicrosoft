from flask import Flask
from premade_estimator import *

app = Flask(__name__)
@app.route('/<a>/<b>/<c>/<d>')
def eval(a,b,c,d):
	return a
if __name__ == '__main__':
    app.run(host='0.0.0.0')