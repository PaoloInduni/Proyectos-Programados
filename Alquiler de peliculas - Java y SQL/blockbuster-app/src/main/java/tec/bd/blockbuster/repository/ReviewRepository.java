package tec.bd.blockbuster.repository;

import java.util.*;

import tec.bd.blockbuster.entities.Review;

public interface ReviewRepository extends CRUDRepository<Review, Integer>{

    List<Review> findAll();

    Optional<Review> findById(Integer entityId);

    Review save(Review entity);

    Review update(Review entity);

    void delete(Integer entityId);
    
}
