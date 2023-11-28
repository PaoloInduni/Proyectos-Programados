import sys
sys.setrecursionlimit(1000000000)

def programaPrincipal():

    cantidad, modo, limite  = map(int,input().split())



    def modo1(n,fac): #Esta función contiene el modo1 de factorización, recibe el número que deseamos factorizar y el factor inicial para realizar el proceso
        if n == 1: #Si el número es 1, retornaremos 1 como factor
            return 1
        if fac > n//2: #Si el número dividido enteramente entre dos llega a ser menor que el factor actual, lo imprimimos y retornamos
            print(n)
            return n
        if n%fac == 0: #Si el número es divisible entre el factorial actual, entonces imprime el factorial e inicia nuevamente el recorrido de la función recursiva
            print(fac, end=" ")
            return modo1(n//fac,fac)
        return modo1(n,fac+1) #Cuando no se cumpla ninguna de las condiciones anteriores, inicia nuevamente el recorrido de la función recursiva



    def modo2(n,fac):
        while n != 1:
            if fac > n//2:
                print(n)
                break
            if n%fac == 0:
                print(fac, end=" ")
                n = n // fac
            else:
                fac += 1



    def modo3(n,fac):
        if n == 1:
            return 1
        if n % 2 == 0:
            print(2, end=" ")
            return modo3(n // 2, fac)
        if (fac*fac) > n:
            print(n)
            return n
        if n%fac == 0:
            print(fac, end=" ")
            return modo3(n//fac,fac)
        return modo3(n,fac+2)



    def modo4(n,fac):
        while n != 1:
            if n%2==0:
                print(2, end=" ")
                n = n//2
            if (fac*fac) > n:
                print(n)
                break
            if  n%fac == 0:
                print(fac, end=" ")
                n = n // fac
            else:
                fac += 2



    def cribaModo5(n):
        listaBooleana = []
        k = 0
        while k * k <= n:
            listaBooleana.append(True)
            k += 1
        listaBooleana[0] = False
        listaBooleana[1] = False
        i = 2
        while i * i <= n:
            if (listaBooleana[i]):
                j = i * i
                while ((j * j) - 1 < n):
                    listaBooleana[j] = False
                    j += i
            i += 1
        return listaBooleana

    def listaCriba(criba):
        lista = []
        for i in range(len(criba)):
            if criba[i] == True:
                lista.append(i)
        return lista

    def modo5(n,criba):
        i = 0
        while n != 0:
            if i == len(criba):
                print(n, end=" ")
                break
            if criba[i] * criba[i] > n:
                print(n, end=" ")
                break
            elif n%criba[i] == 0:
                print(criba[i], end=" ")
                n //= criba[i]
            else: i += 1
        print()



    if modo == 1:
        for i in range(cantidad):
            n = int(input())
            if n>limite:
                print("El último número ingresado es mayor al límite establecido")
                exit()
            modo1(n,2)
    elif modo == 2:
        for i in range(cantidad):
            n = int(input())
            if n>limite:
                print("El último número ingresado es mayor al límite establecido")
                exit()
            modo2(n,2)
    elif modo == 3:
        for i in range(cantidad):
            n = int(input())
            if n>limite:
                print("El último número ingresado es mayor al límite establecido")
                exit()
            modo3(n,3)
    elif modo == 4:
        for i in range(cantidad):
            n = int(input())
            if n > limite:
                print("El último número ingresado es mayor al límite establecido")
                exit()
            modo4(n, 3)
    elif modo == 5:
        criba = listaCriba(cribaModo5(limite))
        for i in range(cantidad):
            n = int(input())
            if n > limite:
                print("El último número ingresado es mayor al límite establecido")
                exit()
            modo5(n,criba)

programaPrincipal()