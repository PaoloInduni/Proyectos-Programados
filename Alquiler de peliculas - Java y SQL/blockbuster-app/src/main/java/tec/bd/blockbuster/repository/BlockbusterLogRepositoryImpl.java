package tec.bd.blockbuster.repository;

import tec.bd.blockbuster.entities.Blockbuster_log;

import java.sql.*;
import java.util.*;

import com.zaxxer.hikari.HikariDataSource;

import static tec.bd.blockbuster.repository.Queries.*;


public class BlockbusterLogRepositoryImpl extends BaseRepository<Blockbuster_log, Integer> implements BlockbusterLogRepository{

    public BlockbusterLogRepositoryImpl (HikariDataSource hikariDataSource) {
        super(hikariDataSource);
    }

    protected Blockbuster_log toEntity(ResultSet resultSet) throws SQLException {
        return new Blockbuster_log
        (
            resultSet.getInt("id"),
            resultSet.getString("table_name"),
            resultSet.getDate("created_on"),
            resultSet.getString("entry_text")
        );
    }

    @Override
    public List<Blockbuster_log> findAll() {

        try {
        
            var stmt = connect().prepareCall(READ_ALL_BB_LOGS);

            return query(stmt);

        } catch (SQLException e) { System.out.println("Error while finding logs in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    public List<Blockbuster_log> findN() {

        try {

            var stmt = connect().prepareCall(READ_LOG);

            return query(stmt);

        } catch (SQLException e) { System.out.println("Error while finding logs in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    public Optional<Blockbuster_log> findById(Integer id) { return (null); }
    public Blockbuster_log save(Blockbuster_log entity) { return (null); }
    public Blockbuster_log update(Blockbuster_log entity) { return (null); }
    public void delete(Integer id) {}

}