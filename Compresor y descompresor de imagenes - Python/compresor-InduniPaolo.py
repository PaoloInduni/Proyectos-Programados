 
# - - - - Lectura de los bytes de un documento - - - - #


#documento = open("foreground2.png", "rb").read()  # Leemos los bytes del documento
#documento = open("LittleTest.txt", "rb").read()
documento = open("examenII.zip", "rb").read()


# - - - - Ciclo para obtener la frecuencia de cada byte - - - - #

contador = [0] * 256  # Creamos una lista vacía con 256 espacios donde guardaremos las frecuencias
for i in documento:  # Recorremos todos los bytes del documento
    contador[i] += 1  # A cada posición, le vamos a sumar 1 cuantas veces se repita

miniContador = contador.copy()

lstArboles = []
for i in range(len(contador)):  # Recorremos la lista final con las frecuencias
    if (contador[i]): # A cada espacio le asignamos su respectivo byte con el sub-arbol asociado
        lstArboles.append([[contador[i], i], [], []])

contador.sort()  # Ordenamos la lista


'''''''''''''''''''''''''''''''''''''''''''''''''''''''''
# - - - - Ciclo para armar el arbol de Huffman - - - - #
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''

while (len(lstArboles) != 1):  # Ya que vamos a ir comprimiendo la lista, acabaremos cuando tenga longitud 1
    sumaFrecuencias = []  # Creamos una lista donde guardaremos el árbol

    izquierda = lstArboles.pop(0)  # Tomamos el sub-arbol izquierdo
    derecha = lstArboles.pop(0)  # Tomamos el sub-arbol derecho

    sumaFrecuencias += [[izquierda[0][0] + derecha[0][0]], izquierda, derecha]  # Sumamos ambas frecuencias y guardamos los sub-árboles asociados

    lstArboles.append(sumaFrecuencias)  # Agregamos la lista combinada a la lista inicial
    lstArboles.sort()  # Ordenamos la lista


'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
# - - - - Función para definir la ruta de cada hoja  - - - - #
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

def rutasHojas(arbol, ruta):  # La función recibe un arbol y una lista
    if (arbol != []):  # Si el arbol no está vacío
        listaRutas = []  # Definimos una lista donde guardamos las diferentes rutas

        if (arbol[1] != []):
            listaRutas += rutasHojas(arbol[1], ruta + "0")  # Si tiene hijo izquierdo lo recorre recursivamente

        if (arbol[2] != []):
            listaRutas += rutasHojas(arbol[2], ruta + "1")  # Si tiene hijo derecho lo recorre recursivamente

        if (listaRutas == []):  # Si la lista de rutas está vacía
            return [[ruta] + [arbol[0][1]]]  # Retornamos la ruta hacia la hoja y dejamos por fuera la frecuencia

        return listaRutas  # Retornamos la lista

    return []  # Cuando el árbol sea vacío, entonces retorna una lista vacía

ruta = ""  # Se define la ruta como un string vacío.
Arbol = lstArboles[0]  # Se define un variable que contiene al arbol de bytes.
listaRutas1 = rutasHojas(Arbol, ruta)  # Se guarda la lista de rutas binarias


listaNueva = [0] * 256  # Se crea una nueva lista vacía
for pos in range(len(listaRutas1)):  # Recorre la lista con las rutas del arbol y los bytes
    listaNueva[listaRutas1[pos][1]] = listaRutas1[pos][0]  # Se guarda la ruta al byte en la posición del valor del byte

"Casos de prueba-----------------------------------------------------------------------"
#documentoComp = open("foreground2.huff", "wb")  # Se escribe el documento ahora .huff
#documentoComp = open("LittleTest.txt", "wb")  # Se escribe el documento ahora .huff
documentoComp = open("examenII.huff", "wb")  # Se escribe el documento ahora .huff


var = ""
for x in documento:
    var += listaNueva[x]

    while (len(var) >= 8):  # Mientras la longitud de var sea mayor a 8
        documentoComp.write(bytes([int(var[:8], 2)]))  # Se escribe el primer byte en el documento comprimido.
        var = var[8:]  # Se recorta el byte de la lista


if (len(var) != 0): # Si la long es diferente de 0

    contador = 0
    while (len(var) != 8):
        var += "0"
        contador += 1

    documentoComp.write(bytes([int(var, 2)]))
    documentoComp.write(bytes([contador])) # Se coloca en el nuevo doc. el valor del contador
else:
    documentoComp.write(bytes([0])) # Se escribe un 0 en el nuevo documento.

documentoComp.close()  # Se cierra el documento, ya comprimido.


'''''''''''''''''''''''''''''''''''''''''''''
# - - - TABLA DE DIRECCIONES DEL DOC - - - #
'''''''''''''''''''''''''''''''''''''''''''''

with open("examenII.zip" + ".table", "w") as escribir:  # Se debe colocar el nombre exacto del documento a probar.
    for i in range(256):  # Recorre los bites
        if miniContador[i] != 0:  # Si es diferente a vacío
            escribir.write(f"{str(i)}:{listaNueva[i]}\n")  # Escribe la posición actual y el valor que contiene.


'''''''''''''''''''''''''''''''''''''''''''''
# - - - - ANCHURA, ALTURA Y NODOS POR NIVEL DEL ARBOL - - - - #
'''''''''''''''''''''''''''''''''''''''''''''

def alturaArbol(arbol):
    if arbol != []:
        return max(alturaArbol(arbol[1]), alturaArbol(arbol[2])) + 1
    return -1

def nodosNivel(arbol, n):
    if arbol != []:
        if n != 0:
            return nodosNivel(arbol[1], n-1) + nodosNivel(arbol[2], n-1)
        return [arbol[0]]
    return []

def anchura(arbol):
    max_anchura = -1

    for nivelActual in range(alturaArbol(arbol)+1):
        cardinalidadNivel = len(nodosNivel(arbol,nivelActual))
        max_anchura = max(max_anchura,cardinalidadNivel)
    return max_anchura

def nodosEnNivel(arbol, n):
    if arbol != []:
        if n != 0:
            return nodosNivel(arbol[1], n-1) + nodosNivel(arbol[2], n-1)
        return [arbol[0]]
    return []

#print("Altura:", alturaArbol(Arbol))
#print("Anchura:", anchura(Arbol))

#for n in range(alturaArbol(Arbol)):
    #print("Nivel {} - Nodos: {}".format(n, len(nodosNivel(Arbol, n))))