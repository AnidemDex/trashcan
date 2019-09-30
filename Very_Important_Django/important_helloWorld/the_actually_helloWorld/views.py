from django.shortcuts import render
from django.http import HttpResponse


def index(request):
    hello_world_str = "<p>ESTOY VIVO!</p> <p>Espera... ¿Cual era mi funcion?</p> <p>Ah, ya: <h2>Hello, world</h2></p>"
    return HttpResponse(hello_world_str)
