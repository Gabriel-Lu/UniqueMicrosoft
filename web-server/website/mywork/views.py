from django.shortcuts import render

# Create your views here.
from django.http import HttpResponse
from .models import infos
from django.views.decorators.csrf import csrf_exempt

@csrf_exempt
def index(request):
	if request.method == 'POST':
		tem = request.POST.get('tem')
		oth = request.POST.get('oth')
		boo = request.POST.get('boo')
		q = infos(tem=tem,oth=oth,boo=boo)
		q.save()
		return HttpResponse('create success')
	if request.method == 'GET':
		return HttpResponse('create failed')