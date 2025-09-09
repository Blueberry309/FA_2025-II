def ejer1():
    nombre=input ("ingrese su nombre:")
    carrera=input ("Ingrese su carrera:")
    #esto es un comentario genial
    print(f"{nombre}, bienvenido a Fundamentos de algoritmos de {carrera}")



def ejer2():
    x=int(input("Ingrese el valor de X: "))
    y=int(input("Ingrese el valor de Y: "))

    print("Suma: ", (x+y))
    print("Resta: ", (x-y))
    print("Multiplicacion: ", (x*y))
    print("Division :",(x/y))



def ejer3 ():
    print("\"Ariana\"")


import math #Importando la libreria math ¡Sin sangria gil!
def ejer4():
    num=float(input("Ingrese un numero decimal"))
    print("Raiz cuadrada: ", math.sqrt(num))
    print("Redondeado: ", round(num,0))
    print("Al cubo: ", math.pow(num,3))
    print("Raiz cubica: ", num**(1/3))

ejer4()
