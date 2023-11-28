#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>
#include "hash_table.c"
#include "hash_table.h"


/*-- NODO --*/

typedef struct node{ //Define la estructura del nodo usado para representar las ciudades
    char* name;
    int interest;
    struct node* next;
    HT* inventory;
} node;


/*-- LISTA --*/

node* create_list(node* list){ //Función que crea una lista
    list = NULL;
    return list;
}


/*-- PRODUCTO --*/

typedef struct product{ //Define la estructura del producto usado en la tabla de hash

    int price;
    int amount;

}product;


/*-- LLENAR PRODUCTO --*/

product* create_product(){ //Función para crear un producto

	product* new_product = calloc(1,sizeof(product)); //Asignamos valores al producto
	new_product->price=(rand()%76) + 10;
	new_product->amount=(rand()%50) + 50;

    return new_product;
}


/*-- FUNCIÓN PARA LLENAR LA TABLA DE HASH --*/

char* products[5] = {"Aceite de cáñamo", "Ropa de cáñamo", "Pomada de cáñamo", "Semillas de cáñamo", "Tela de cáñamo"}; //Arreglo de donde se obtienen los derivados del cáñamo

void fill_HT(HT* some_product){ //recibe la tabla de hash donde guardaremos los valores

	for(int i=0; i< sizeof(products)/sizeof(products[0]); i++){ //Llenamos la tabla de hash con los elementos del arreglo "products"

		char* product_name = products[i];
        product* new_product = create_product();
        add_node_HT(some_product, product_name, strlen(product_name), new_product);

	}
}


/*-- INVENTARIO JUGADOR --*/

typedef struct player_inventory{ //Define la estructura  del inventario del jugador
    int gold;
    HT* inventory;
}player_inventory;


/*-- LLENAR INVENTARIO JUGADOR --*/

player_inventory* create_inventory(){

    player_inventory* new_inventory = calloc(1,sizeof(player_inventory)); //Reservamos el espacio para la tabla
	new_inventory->gold = 2500; //Asignamos la cantidad de oro inicial

	HT* product_table = create_HT(); //Creamos una tabla
    fill_HT(product_table); //Llenamos esa tabla

	new_inventory->inventory = product_table; //Guardamos la tabla en el inventario de la tabla creada
	
    return new_inventory;
}


/*-- GENERAR INTERÉS RANDOM --*/

int random_interest(){

    srand(rand()*time(NULL)*(rand()%rand()+rand()));
    int random = rand() % 100 + 1; //Genera un valor de interés aleatorio entre 1 y 100

    return random;
}


/*-- GENERAR CAMBIO EN EL INTERÉS TRAS UNA PROMOCIÓN --*/

int random_promotion(){
    srand(rand()*time(NULL)*(rand()%rand()+rand()));
    int randomFifty = rand() % 2; //Genera un valor de promoción aleatorio entre 0 y 1, esto dicta si se aumentará o restará interés
    int random = rand() % 15 + 1; //Genera el valor en el que aumentará o disminuirá el interés (no mayor a 15)

    if(randomFifty == 0){ //Si sale 0, se resta

        return 0 - random;
    }else{ //Si sale 1, se suma
    
        return random;
    }

    return random;
}


/*-- REVISAR CIUDADES CON INTERÉS --*/

int check_interest(node* list){ //Función para verificar si aún hay ciudades interesadas
    
    node* act = list; //Creamos un nodo temporal para recorrer la lista
    int int_amount = 0;

    while(act->next != NULL){ //Mientras que no estemos en el último elemento de la lista

        if(act->interest > 30){ //Si el interés del nodo actual es mayor a 30
            int_amount += 1; //Sumamos 1 a la cantidad de ciudades interesadas
        }
        act = act->next;
    }
    
    if(int_amount > 0){
        return 1;
    }
    return 0;
}


/*-- AÑADIR NODO --*/

node* add_node(node* list, char* name, int interest){ //Esta función añade un nodo a la lista con los parámetros especificados


    /*-- CREACIÓN DEL NUEVO NODO --*/

    node *new_node, *act; //Crea un nuevo nodo y una variable de paso
    new_node = calloc(1,sizeof(node)); //Reserva el espacio de memoria para el nod


    /*-- ASIGNAR LOS VALORES AL NODO --*/

    new_node->name = name; //Asigna el nombre al nodo (ciudad)
    new_node->interest = interest; //Asigna el interes al nodo (ciudad)
    new_node->next = NULL; //Especificamos que el nuevo nodo apunta a NULL (Ya que será insertado al final de la lista)
    
    HT* product_table = create_HT();
    fill_HT(product_table);
    new_node->inventory = product_table;


    /*-- INSERTAR A LA LISTA --*/

    if(list == NULL){ //Cuando la lista esté vacía

        list = new_node; //El nuevo nodo pasa a ser la lista

    }else{ //Cuando la lista no esté vacía

        act = list; //El valor temporal es la lista en su estado actual

        while(act->next != NULL){ //Mientras que el espacio siguiente no sea el último de la lista (act->next != NULL)

            act = act->next; //Nos movemos al siguiente espacio de la lista
        }

        act->next = new_node; //Asignamos el nuevo nodo como el último valor de la lista

    }
    return list; //Retornamos la lista
}


/*-- FUNCIÓN PARA LLENAR LA LISTA --*/

node* fill_list(int city_amount){ //La función recibe la cantidad de ciudades con las que se desea jugar

    char* cities[10] = {"Alajuelita", "Barrio San José", "Desamparados", "Guadalupe", "Pavas", "Hatillo", "La Carpio", "León XIII", "Limón", "Tuetal"}; //Arreglo de donde se obtienen las ciudades

    node* list = create_list(list); //Creamos una lista para guardar las ciudades

    for(int i = 0; i <= city_amount; i++){ //Un for que nos ayuda a recorrer el array

        list = add_node(list, cities[i], random_interest()); //Añadimos el elemento del arreglo a la lista
    }
    return list;
}


/* IMPRIMIR INVENTARIO DEL JUGADOR */

void print_inventory(player_inventory* p_inv){ //Recibe la tabla que se quiere imprimir
    printf("\nTU INVENTARIO - ");
    printf("ORO: %d\n",p_inv->gold);

    HT* inventory = p_inv->inventory; //creamos una tabla llamada inventory

    for(int i = 0; i<sizeof(products)/sizeof(products[0]); i++){ //Recorremos el arreglo con productos

        char* product_name = products[i]; //Guardamos el nombre del producto
        product* product = find_value_HT(inventory, product_name, strlen(product_name)); //Guardamos los valores de la tabla                
            printf("\t-%s   \t[CANTIDAD: %d]\n", product_name, product->amount); //Imprimimos todo con el formato indicado
        }
}


/*-- IMPRIMIR LISTA --*/

void print_list(node* list){ //Recibe la lista que se desea imprimir

    node* act = list; //Creamos la variable temporal act

    while(act->next != NULL){ //Mientras no estemos en el último elemento

        printf("\n%s",act->name); //Imprimimos nombre e interés
        printf(" - Interés: %d\n",act->interest);

        act = act->next; //Avanzamos al siguiente elemento

        for(int i = 0; i<sizeof(products)/sizeof(products[0]); i++){ //Recorremos el arreglo "products"

            char* product_name = products[i]; //Guardamos el nombre del producto
            printf("\t-%s", product_name);
                
            HT* inventory = act->inventory; //Guardamos la tabla del espacio actual  
            
            product* product = find_value_HT(inventory, product_name, strlen(product_name)); //Guardamos la tabla del inventario actual                
            printf("   \t[CANTIDAD: %d]\t[PRECIO: %d]\n", product->amount, product->price ); //Imprimimos con el formato indicado
        }
    }
}


/*-- ENCONTRAR NODO --*/

node* find_node(node* list, int selection){ //Recibe la lista y la posición del nodo que se busca

    node* act = list; //Creamos la variable temporal act
    int counter=1; //Iniciamos un contador

    while(counter < selection){ //Mientras no hallamos alcanzado el elemento especificado

        act = act->next; //Avanzamos al siguiente elemento y aumentamos el contador
        counter++;
    }

    return act; //Retornamos el NODO buscado
}


/*-- INTERCAMBIO --*/

void trade(node* c_inv, player_inventory* p_inv, int product_selection, int amount_selection){ //Recibe la ciudad, inventario del jugador, producto y cantidad especificados

    char* productName = products[product_selection]; //Guardamos el nombre del producto que se está intercambiando

    HT* p_inventory = p_inv->inventory; //Llamamos al inventario del jugador
    HT* c_inventory = c_inv->inventory; //Llamamos al inventario de la ciudad

    product* player_product = find_value_HT(p_inventory,productName, strlen(productName)); //Guardamos los valores de ESE PRODUCTO en el inventario del jugador
    product* city_product = find_value_HT(c_inventory,productName, strlen(productName)); //Guardamos los valores de ESE PRODUCTO en el inventario de la ciudad

        if(p_inv->gold - city_product->price*amount_selection > 0){ //Si el intercambio es posible

            player_product->amount += amount_selection; //Cambiamos los valores respectivos a cada inventario
            city_product->amount -= amount_selection;
            p_inv->gold -= city_product->price * amount_selection;

            printf("\nSe intercambió %d oro por %d %s\n", amount_selection, amount_selection*city_product->price, productName);

        }else{ //Si no es posible

            printf("No tienes suficiente oro para intercambiar! prueba con una cantidad más pequeña!"); //Pedimos que pruebe con otra ciudad
        }
        
        c_inv->interest+=random_promotion(); //Luego del intercambio (o intento de intercambio) el interés aumenta o disminuye aleatoreamente
}

/*-- FUNCIÓN DEL JUEGO PRINCIPAL --*/

int main(){

    /*-- DECLARACIÓN DE VARIABLES --*/

    int repeat = 1;

    while(repeat != 0){

        /*-- DECLARACIÓN DE VARIABLES --*/

        int round = 1;
        int city_amount = 0;
        int game_over = 0;
        int action = 0;
        int city_selection = 0;
        int product_selection = 0;
        int amount_selection = 0;

        /*-- INICIO DEL JUEGO --*/

        printf("Bienvenido a [MOTA O PLOMO], por favor seleccione la cantidad de ciudades con las que desea jugar: [3-10] "); //Pedimos al usuario que ingrese la cantidad de ciudades con las que desea jugar
        scanf("%d", &city_amount);

        if(city_amount < 3 || city_amount > 10){ //Verificamos si el usuario ingresó una cantidad válida
            printf("Por favor inrese una cantidad de ciudades valida!\n");
            continue;
        }

        node* list = fill_list(city_amount); //Llenamos la lista con los valores del arreglo
        node* act = list; //Usamos un puntero temporal para recorrer la lista
        player_inventory* p_inv = create_inventory();

        printf("Inicia el juego! estas son las ciudades con las que jugarás:\n\n");

        print_list(list); //Mostramos las ciudades con su respectiva información
        print_inventory(p_inv);

        while(game_over != 1 && round <= 7 && check_interest(list) == 1){

            printf("\nRonda [%d], indique la acción que desea realizar:\n\n[1] - Intercambiar\n[2] - Promocionar\n",round);
            scanf("%d", &action);

            switch(action){ //Switch para seleccionar la acción deseada en la ronda
                
                case 1: //1 = INTERCAMBIAR

                    act = list;
                    int counter = 1;

                    printf("\nSeleccione la ciudad con la que desea comerciar:\n"); //Mostramos las ciudades

                    while(act->next != NULL){
                        printf("[%d] - %s\n", counter,act->name);
                        act = act->next;
                        counter+=1;
                    }

                    scanf("%d", &city_selection); //Recibimos la ciudad

                    if(find_node(list, city_selection)->interest > 30){ //Si la ciudad seleccionada está interesada
                        
                        printf("\nCuál producto desea intercambiar?:\n[0] - Aceite de cáñamo\n[1] - Ropa de cáñamo\n[2] - Pomada de cáñamo\n[3] - Semillas de cáñamo\n[4] - Tela de cáñamo\n");
                        scanf("%d", &product_selection); //Mostramos y pedimos que seleccione un producto

                        printf("Cuánto desea intercambiar?\n");
                        scanf("%d", &amount_selection); //Pedimos la cantidad deseada

                        trade(find_node(list, city_selection+1), p_inv, product_selection, amount_selection); //Realizamos el intercambio (de ser posible)

                        print_list(list); //Imprimimos los inventarios resultantes
                        print_inventory(p_inv);

                    }else{ //Si no lo está:

                        printf("La ciudad no está interesada en comerciar, prueba con otra!"); //Pedimos que pruebe con otras ciudad
                        continue;
                    }

                    round += 1;

                    break;

                case 2: //2 = PROMOCIONAR

                    act = list;

                    while(act->next != NULL){ //Realizamos la promoción y se alteran los valores
                        act->interest += random_promotion();
                        act = act->next;
                    }

                    printf("Este es el interés actual luego de la promoción:\n\n"); // Mostramos los resultados

                    act = list;

                    while(act->next != NULL){
                        printf("%s",act->name);
                        printf(" - interés: %d\n",act->interest);
                        act = act->next;
                    }

                    round += 1;

                    break;

                default: //Verificamos que haya ingresado un valor válido
                    printf("Por favor ingrese una acción válida!\n"); 
                    break;

            }
        }

        if(check_interest(list) == 0){ //En este punto terminó el juego, verificamos si fue porque el interés cayó, en ese caso el jugador perdió

            printf("El nivel de interés de las ciudades ha caído demasiado! Quieres intentarlo de nuevo?\n[1] - Sí\n[0] - No\n");
            scanf("%d", &repeat);

        }else{ //Si el juego terminó porque superó todas las tondas, significa que el jugador ganó

            printf("\nHas ganado! Las ciudades siguen interesadas! Deseas jugar otra vez?\n[1] - Sí\n[0] - No\n");
            scanf("%d", &repeat);
        }

    }

    return 0;
}