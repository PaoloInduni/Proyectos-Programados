import sys

#### FUNCIONES PARA RECIBIR LAS PIEZAS

def leer_piezas(cantidad_p):
    piezas = []
    contador = 1

    while cantidad_p:
        anadir = input("")
        piezas+=[[i for i in anadir]]
        contador += 1
        cantidad_p -= 1
    return piezas

def dividir(lista):
    contador=1
    to_add=[]
    new_list=[]

    for i in lista:
        if contador%4!=0:
            to_add.append(i)
            contador+=1
        else:
            to_add.append(i)
            new_list.append(to_add)
            to_add=[]
            contador+=1
    return new_list

#### FUNCIONES DE APOYO

def crearMatrizVacia(filas,columnas):
    matriz_nueva = [["."]] * filas
    for posFila in range(filas):
        matriz_nueva[posFila] = matriz_nueva[posFila] * columnas
    return matriz_nueva

def imprimirMatriz(matriz):
    for fila in range(len(matriz)):
        for col in range(len(matriz[0])):
            print ("{:<3} ".format(matriz[fila][col]),end=" ")
        print()
    print()

def copiar(matriz):
    copia = []
    for i in matriz:
        copia.append(i.copy())
    return copia

#### FUNCIONES PARA TRABAJAR LAS PIEZAS

def cortarPieza(pieza):

    silueta = copiar(pieza) #Posiblemente no haga falta hacer deep copy
    filas = len(pieza)
    cols = len(pieza[0])
    for fila in range(filas-1,-1,-1):
        status = False

        for col in range(cols):
            if silueta[fila][col] != '.':
                status = True
                break
        if not status:
            silueta.remove(silueta[fila])

    for col in range(cols-1,-1,-1):
        status = False

        for fila in range(len(silueta)):
            if silueta[fila][col] != ".":
                status = True
                break
        if not status:
            for i in range(len(silueta)):

                silueta[i].pop(col)

    return silueta

def cortar_piezas(lista_de_piezas):
    for i in range(len(lista_de_piezas)):
        lista_de_piezas[i]=cortarPieza(lista_de_piezas[i])
    return lista_de_piezas

def rotarPieza(pieza):
    piezaRotada = crearMatrizVacia(len(pieza[0]),len(pieza))
    for i in range(len(piezaRotada)):
        for j in range(len(piezaRotada[0])):
            piezaRotada[i][j] = pieza[len(pieza)-1-j][i]
    return piezaRotada

def transpuesta(pieza):
    piezaTranspuesta = crearMatrizVacia(len(pieza[0]),len(pieza))
    for i in range(len(piezaTranspuesta)):
        for j in range(len(piezaTranspuesta[0])):
            piezaTranspuesta[i][j] = pieza[j][i]
    return piezaTranspuesta

#### FUNCIÓN PARA GUARDAR ROTACIONES

def ocho_hijos(pieza):

    pieza=cortarPieza(pieza)
                                    #Las 8 rotaciones de una pieza con forma de palo son identicas, entonces hay que revisar si hacemos un set o algo,con un set podria resolverse
    hijos=[pieza]
    pieza=rotarPieza(pieza)
    hijos+=[pieza]

    pieza = rotarPieza(pieza)
    hijos += [pieza]

    pieza = rotarPieza(pieza)
    hijos+=[pieza]
                                    #Solo 3 rotaciones puesto que la posicion original ya esta en la lista


                                    #Aqui empiezan las transpuestas

    pieza = transpuesta(pieza)
    hijos+=[pieza]

    pieza = rotarPieza(pieza)
    hijos += [pieza]

    pieza = rotarPieza(pieza)
    hijos += [pieza]

    pieza = rotarPieza(pieza)
    hijos += [pieza]
    return hijos

#### FUNCIÓN PRINCIPAL

def moverPieza(tablero, piezas,soluciones,rotaciones):

    pieza=rotaciones[0]
    sol=False
    solucion=[]

    filas = len(tablero)
    cols = len(tablero[0])

    for fila in range(0,filas-(len(pieza)-1)):
        for col in range(0,cols-(len(pieza[0])-1)):

            silueta = copiar(tablero)
            status = True

            for i in range(0,len(pieza)):
                for j in range(0,len(pieza[0])):
                    if pieza[i][j]==".":
                        continue    #No hacer rememplazos innecesarios, queda ver si es eficiente tener ese if en vez de hacer el reemplazo
                                    #Creo que sí es necesario, puesto que si se intenta hacer el cambio y en la posicion hay algo diferente a "." el va a interpretar como que la solucion no es valida
                    if silueta[fila+i][col+j] =='.': #Verifica si en esa posicion del tablero hay algo que no sea un punto
                        silueta[fila+i][col+j] = pieza[i][j]
                    else:
                        status=False #Da status false puesto que si en 1 posiciones no se puede poner la pieza, no hace falta seguir verificando
                        break

                if not status:
                    break           #Hace break al ciclo para probar con el siguiente movimiento
            if status:

                new_tablero = silueta
                if len(piezas)==1:
                    imprimirMatriz(silueta)
                    sys.exit()

                if (moverPieza(new_tablero,piezas[1:],soluciones,ocho_hijos(piezas[1])))==True:
                    pass
                                    #Recursividad, elimina la primera pieza de la lista, y sigue trabajando con el resto
                else:
                    status=False
                    continue        #No se encontro solucion con esa posicion de pieza, entonces se sigue el ciclo
                                    #Podria hacer que esto retorne true

                #Revisar el ocho hijos, piezas[1]

    if len(rotaciones)<=1:          #Si no la puede poner, y no quedan rotaciones, debera intentar con la misma rotacion en otra posicion
        return False

    moverPieza(tablero,piezas, soluciones, rotaciones[1:])

    return False

#### INTERFAZ DEL JUEGO

def juego():
    largo, ancho, cantidad_p = map(int, input("Digite largo,ancho y cantidad de piezas: \n").split())

    cantidad_p*=4

    matrix=crearMatrizVacia(largo,ancho)
    print('Ingrese las piezas: ')
    piezas=leer_piezas(cantidad_p)
    piezas=dividir(piezas)

    rotaciones = ocho_hijos(piezas[0])
    piezas=cortar_piezas(piezas)

    moverPieza(matrix, piezas, [], rotaciones)

    print('No hay solución')

juego()
