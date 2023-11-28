#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <stdbool.h>
#include "hash_table.h"

#define MAX_SIZE 	256*256


/*-- FUNCIÓN DE HASH --*/

static unsigned int hash_function(char* key, unsigned int key_size){ //Recibe el key (String del producto) y su longitud

	unsigned int hash = 1315423911;
	unsigned int i = 0;

	for(i = 0; i < key_size; key++, i++){
		hash ^= ((hash << 5) + (*key) + (hash >> 2)); //Esta función es un milagro...
	}

	return hash;
}


/*-- NODO PARA LA TABLA DE HASH --*/

static void create_node_HT(HN *node){ //Funciona como un constructor a la estructura definida en <hashTable.h>
	node->next = NULL;
	node->key = NULL;
	node->value = NULL;
	node->collision = false;
}


/* CREAR TABLA DE HASH*/

HT* create_HT(void){

	HT *hash_table = (HT *)malloc(sizeof(HT)); //Apartamos la memoria para la tabla
	hash_table->internal_table = malloc(sizeof(HN) * MAX_SIZE);

	memset(hash_table->internal_table, 0, sizeof(HN) * MAX_SIZE); //Inicializamos los nodos internos
	
	return hash_table; //Retornamos la tabla
}


/*-- AGREGAR NODO A TABLA DE HASH --*/

int add_node_HT(HT *hash_table, char *key, unsigned int key_size, void *node_value){ //Recibe la tabla de hash, el key (en este caso el nombre del producto), longitud del key y el valor del nodo

	unsigned int i = hash_function(key, key_size) % MAX_SIZE; //Obtiene el index en la tabla de hash correspondiente a "key"

	HN *HT_node = hash_table->internal_table[i];  //Buscamos el valor en ese index
	HN *HT_previous_node = HT_node; //Esta variable va a ir un nodo atrás
	
	while(HT_node){ //Recorremos la tabla
	
		if (strncmp(key, HT_node->key, key_size) == 0 ){	//Si el valor es el mismo, entonces actualizamos
		
			if(HT_node->collision){
				HT_node->value = node_value; //Cambiamos el valor
				HT_node->collision = true; // Indicamos que está lleno
				break;
			}
		}

		HT_previous_node = HT_node;
		HT_node = HT_node->next;
	}
	
	if(!HT_node){ //Si está vacío
	
		HN *new_HT_node_key = (HN *)malloc(sizeof(HN)); //Apartamos memoria
		create_node_HT(new_HT_node_key); //Creamos el nodo

		char *new_NT_node_key = (char *)malloc(key_size+1); //Asignamos el espacio para el key del nuevo nodo

		if(!new_NT_node_key){

			free(new_HT_node_key);
			new_HT_node_key = NULL;
			return -1;
		}

		//GENERAMOS LOS VALORES DEL NUEVO NODO DE LA TABLA

		strncpy(new_NT_node_key, key, key_size);
		new_HT_node_key->key = new_NT_node_key;
		new_HT_node_key->value = node_value;
		new_HT_node_key->collision = true;
		
		if(!HT_previous_node){ //Si el nodo anterior está vacío
		
			hash_table->internal_table[i] = new_HT_node_key; //Rellena el nodo actual de la tabla interna
		}
		else{ //Si el nodo anterior está lleno
		
			HT_previous_node->next = new_HT_node_key; //Rellena el nodo anterior
		}
	}
	
	return 0;
}


/*-- ENCONTRAR UN VALOR EN LA TABLA --*/

void *find_value_HT(HT *hash_table, char *key, unsigned int key_size){ //Recibe la tabla, el key y su longitud.

	int i = hash_function(key,key_size) % MAX_SIZE;

	HN *HT_node_key = hash_table->internal_table[i]; //Guardamos la información del nodo según el valor de hash generado
	
	while(HT_node_key)	{ //Recorremos la tabla

		if(strncmp(HT_node_key->key, key, key_size) == 0){  //Verificamos si el string coincide con el valor guardado en el índice de la tabla de hash
		
			return HT_node_key->value; //Retornamos el valor
		}

		HT_node_key = HT_node_key->next; //Avanzamos al siguiente elemento
	}
	
	return NULL;
}