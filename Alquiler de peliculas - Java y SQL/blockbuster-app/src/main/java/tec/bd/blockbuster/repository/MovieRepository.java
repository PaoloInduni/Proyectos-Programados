package tec.bd.blockbuster.repository;

import java.util.*;

import tec.bd.blockbuster.entities.Movie;

public interface MovieRepository extends CRUDRepository<Movie, Integer> {

    List<Movie> findAll();

    Optional<Movie> findById(Integer entityId);

    Movie save(Movie entity);

    Movie update(Movie entity);

    void delete(Integer entityId);
}