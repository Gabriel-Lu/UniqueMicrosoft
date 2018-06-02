from django.db import models

# Create your models here.
class infos(models.Model):
	airtem = models.FloatField(default=0.0)
	airhum = models.FloatField(default=0.0)
	oilhum = models.FloatField(default=0.0)
	light = models.FloatField(default=0.0)