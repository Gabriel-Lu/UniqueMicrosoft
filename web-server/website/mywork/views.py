from django.shortcuts import render

# Create your views here.
from django.http import HttpResponse
from .models import infos
from django.views.decorators.csrf import csrf_exempt

@csrf_exempt
def index(request):
	if request.method == 'POST':
		airtem = request.POST.get('airtem')
		airhum = request.POST.get('airhum')
		oilhum = request.POST.get('oilhum')
		light = request.POST.get('light')
		q = infos(airtem=airtem,airhum=airhum,oilhum=oilhum,light=light)
		q.save()
		return HttpResponse('create success')
	if request.method == 'GET':
		return HttpResponse('create failed')