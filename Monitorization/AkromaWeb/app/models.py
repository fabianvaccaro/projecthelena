"""
Definition of models.
"""

from django.db import models
from mongoengine import *

# Create your models here.
class DeviceLog(Document):
    entrydate = DateTimeField()
    message = StringField()

class CaptureLog(Document):
    entrydate = DateTimeField()
    filename = StringField()
    is_served = BooleanField()

class Message(EmbeddedDocument):
    body = StringField()
    entrydate = DateTimeField()
    is_served = BooleanField()

class Conversation(Document):
    incoming = ListField(EmbeddedDocumentField(Message))
    outgoing = ListField(EmbeddedDocumentField(Message))