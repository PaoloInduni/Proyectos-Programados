package tec.bd.blockbuster.repository;

import java.io.Serializable;
import java.util.*;

public interface CRUDRepository<T, ID extends Serializable> {

    List<T> findAll();

    Optional<T> findById(ID entityId);

    T save(T entity);

    T update(T entity);

    void delete(ID entityId);
}