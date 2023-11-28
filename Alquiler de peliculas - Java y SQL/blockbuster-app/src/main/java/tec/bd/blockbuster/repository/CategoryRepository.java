package tec.bd.blockbuster.repository;

import java.util.*;

import tec.bd.blockbuster.entities.Category;

public interface CategoryRepository extends CRUDRepository<Category, Integer> {

    List<Category> findAll();

    Optional<Category> findById(Integer entityId);

    Category save(Category entity);

    Category update(Category entity);

    void delete(Integer entityId);

}