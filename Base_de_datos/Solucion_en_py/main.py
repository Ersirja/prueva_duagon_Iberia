def invertir_texto(texto):
    return texto[::-1]

texto_propuesto = "Hola mundo, este es un texto para darle la vuelta"
solucion = invertir_texto(texto_propuesto)

print("Texto propuesto: ", texto_propuesto)
print("Solución: ", solucion)