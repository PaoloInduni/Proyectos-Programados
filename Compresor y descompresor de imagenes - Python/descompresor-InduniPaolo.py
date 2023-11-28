
# - - - - Lectura de los bytes de un documento - - - - #


# tabla = open("foreground2.png.table", "r").read().split("\n")
tabla = open("examenII.zip.table", "r").read().split("\n")  # Se abre la tabla de direcciones del doc.



# - - - - Función Para Reconstruir el Árbol - - - - #


def reconstruir(camino, byte, arbol, principal=True):
    if ((camino == "") and (principal)):  # Si camino está vacío se retorna la hoja con el byte.
        return [byte, [], []]

    if (principal):  # Si 'principal' es igual 'True'
        if (arbol == []):
            arbol = [None, [], []]  # Auxiliar. Convierte hoja en un nodo.

        if (camino[0] == "0"):  # Si 'camino' en subzero es '"0"'
            return [None, reconstruir(camino[1:], byte, arbol[1], True), reconstruir(camino, byte, arbol[2], False)]
            # Se resconstruye la rama izquiera del árbol.

        return [None, reconstruir(camino, byte, arbol[1], False), reconstruir(camino[1:], byte, arbol[2], True)]
        # Se resconstruye la rama derecha del árbol.

    return arbol  # Cuando 'principal' se indique como false se retorna 'arbol'.

tabla.pop()

arbol = []
for i in tabla:
    arbol = reconstruir(i.split(":")[1], int(i.split(":")[0]), arbol)


#huff = open("foreground2.huff", "rb").read()
#huff = open("LittleTest.huff", "rb").read()
huff = open("examenII.huff", "rb").read()  # Leemos los bytes del doc y se guarda en 'huff'
huff, extra = huff[:-1], huff[-1]  # 'huff' se redefine para separar la información y se guarda en 'extra' (cant. adicional de bites)

def recorrer():
    puntero = 0  # Indica el byte que se va a trabajar.
    byteA = "0" * (8 - len(bin(huff[puntero])[2:])) + bin(huff[puntero])[2:] # Byte actual en fromato 'str'
    miniarbol = arbol  # Se crea una 'copia' del árbol.
    escribir = open("archivoComprimido", "wb") # Se define un nombre prestablecido para el doc descomprimido.

    while (puntero < len(huff) - 1):
        bit = int(byteA[0])

        byteA = byteA[1:]
        if (byteA == ""):
            puntero += 1
            byteA = "0" * (8 - len(bin(huff[puntero])[2:])) + bin(huff[puntero])[2:]

        if (miniarbol[0] != None):
            escribir.write(bytes([miniarbol[0]]))
            miniarbol = arbol
        miniarbol = miniarbol[bit + 1]

    byteA = byteA[:8 - extra]
    while (byteA != ""):
        bit = int(byteA[0])
        byteA = byteA[1:]

        if (miniarbol[0] != None):
            escribir.write(bytes([miniarbol[0]]))
            miniarbol = arbol
        miniarbol = miniarbol[bit + 1]

    escribir.close()  # Se cierra el documento.

recorrer()  # Se llama a la función para que se ejecute.