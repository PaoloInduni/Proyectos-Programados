package tec.bd.blockbuster.repository;

import java.util.*;

import tec.bd.blockbuster.entities.Rental;

public interface RentalRepository extends CRUDRepository<Rental, Integer>{
    
    List<Rental> findAll();

    Optional<Rental> findById(Integer entityId);

    Rental save(Rental entity);

    Rental update(Rental entity);

    void delete(Integer entityId);

}
