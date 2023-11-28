#ifndef HASHTABLE_H
#define HASHTABLE_H

#include <stdbool.h>

typedef struct hash_node{

	struct hash_node *next;	
	char *key;				
	void *value;			
	bool collision;
	
}HN;

typedef struct hash_table{
	HN **internal_table;	
}HT;

HT* create_hash_table(void);

int add_node2HashTable(HT *hash_table, char *key, unsigned int key_len, void *value);

void *get_value_from_hstable(HT *hash_table, char *key, unsigned int key_len);

void hash_table_delete(HT *hash_table);


#endif