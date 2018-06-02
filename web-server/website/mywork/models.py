from django.db import models

# Create your models here.
class infos(models.Model):
	tem = models.IntegerField(default=0)
	oth = models.CharField(max_length=100)
	boo = models.BooleanField()