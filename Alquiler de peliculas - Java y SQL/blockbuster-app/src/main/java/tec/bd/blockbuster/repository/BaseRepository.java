package tec.bd.blockbuster.repository;

import com.zaxxer.hikari.HikariDataSource;

import java.io.Serializable;
import java.sql.*;
import java.util.*;

import javax.sql.DataSource;

public abstract class BaseRepository<T, ID extends Serializable> implements CRUDRepository<T, ID> {

    protected DataSource dataSource;

    protected BaseRepository(HikariDataSource hikariDataSource)
    {
        this.dataSource = hikariDataSource;
    }

    protected Connection connect() throws SQLException {
        return this.dataSource.getConnection();
    }

    protected ResultSet rawQuery(String sqlQuery) throws SQLException {
        var connection = this.connect();
        Statement stmt = connection.createStatement();
        return stmt.executeQuery(sqlQuery);
    }

    protected void rawUpdate(String sqlQuery) throws SQLException {
        var connection = this.connect();
        Statement stmt = connection.createStatement();
        try {
            stmt.executeUpdate(sqlQuery);
        } catch (SQLException e) {
            throw e;
        } finally {
            stmt.close();
        }
    }

    //Alistamos funciones para ambos casos, ya sean queries almacenados o no

    protected void update(String sqlQuery) throws SQLException {
        this.rawUpdate(sqlQuery);
    }

    protected void update(PreparedStatement statement) throws SQLException {
        statement.executeUpdate();
    }

    protected List<T> query(String sqlQuery) throws SQLException {
        ResultSet resultSet = this.rawQuery(sqlQuery);
        return this.resultSetToEntityList(resultSet);
    }

    protected List<T> query(PreparedStatement statement) throws SQLException {
        ResultSet resultSet = statement.executeQuery();
        return this.resultSetToEntityList(resultSet);
    }

    protected List<T> resultSetToEntityList(ResultSet resultSet) throws SQLException {
        var entities = new ArrayList<T>();
        while(resultSet.next()) {
            var entity = toEntity(resultSet);
            if(null != entity) {
                entities.add(entity);
            }
        }
        return entities;
    }

    protected abstract T toEntity(ResultSet resultSet) throws SQLException;
}