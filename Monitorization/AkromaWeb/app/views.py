"""
Definition of views.
"""

from django.shortcuts import render
from django.http import HttpRequest
from django.template import RequestContext
from datetime import datetime

def home(request):
    """Renders the home page."""
    assert isinstance(request, HttpRequest)
    return render(
        request,
        'app/index.html',
        {
            'title':'Inicio',
            'year':datetime.now().year,
        }
    )

def start_mon(request):
    """Renders the home page."""
    assert isinstance(request, HttpRequest)
    return render(
        request,
        'app/mon.html',
        {
            'title':'Monitorizando',
            'year':datetime.now().year,
        }
    )

def finished(request):
    """Renders the home page."""
    assert isinstance(request, HttpRequest)
    return render(
        request,
        'app/finished.html',
        {
            'title':'Terminado',
            'year':datetime.now().year,
        }
    )