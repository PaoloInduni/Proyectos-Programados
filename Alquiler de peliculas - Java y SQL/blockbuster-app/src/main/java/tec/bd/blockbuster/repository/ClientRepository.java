package tec.bd.blockbuster.repository;

import java.util.*;

import tec.bd.blockbuster.entities.Client;

public interface ClientRepository extends CRUDRepository<Client, Integer> {

    List<Client> findAll();

    Optional<Client> findById(Integer entityId);

    Client save(Client entity);

    Client update(Client entity);

    void delete(Integer entityId);
    
}