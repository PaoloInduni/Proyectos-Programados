package tec.bd.blockbuster.repository;

import java.util.*;

import tec.bd.blockbuster.entities.Blockbuster_log;

public interface BlockbusterLogRepository extends CRUDRepository<Blockbuster_log, Integer>{
    
    List<Blockbuster_log> findAll();

    List<Blockbuster_log> findN();

    Optional<Blockbuster_log> findById(Integer entityId);

    Blockbuster_log save(Blockbuster_log entity);

    Blockbuster_log update(Blockbuster_log entity);

    void delete(Integer entityId);

}