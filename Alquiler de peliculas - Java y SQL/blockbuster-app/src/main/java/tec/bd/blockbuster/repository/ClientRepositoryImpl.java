package tec.bd.blockbuster.repository;

import tec.bd.blockbuster.entities.Client;

import java.sql.*;
import java.util.*;

import com.zaxxer.hikari.HikariDataSource;

import static tec.bd.blockbuster.repository.Queries.*;


public class ClientRepositoryImpl extends BaseRepository<Client, Integer> implements ClientRepository {

    public ClientRepositoryImpl (HikariDataSource hikariDataSource) {
        super(hikariDataSource);
    }

    protected Client toEntity(ResultSet resultSet) throws SQLException {
        return new Client
        (
            resultSet.getInt("id"),
            resultSet.getString("name"),
            resultSet.getString("lastname"),
            resultSet.getString("email"),
            resultSet.getString("phone_number")
        );
    }

    public List<Client> findAll() {

        try {
        
            var stmt = connect().prepareCall(READ_ALL_CLIENTS);

            return query(stmt);

        } catch (SQLException e) { System.out.println("Error when finding clients in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    public Optional<Client> findById(Integer id) {

        try {
            
            var stmt = connect().prepareCall(READ_CLIENT);
            stmt.setInt(1, id);

            return query(stmt).stream().findFirst();

        } catch (SQLException e) { System.out.println("Error when finding client in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }


    public Client save(Client entity) {

        try{

            var stmt = connect().prepareCall(CREATE_CLIENT);
            stmt.setString(1, entity.getName());
            stmt.setString(2, entity.getLastname());
            stmt.setString(3, entity.getEmail());
            stmt.setString(4, entity.getPhone_number());
            stmt.registerOutParameter("p_new_client_id", Types.INTEGER);
            stmt.executeQuery();

            var newClientId = stmt.getInt("p_new_client_id");
            entity.setId(newClientId);

            return(entity);

        } catch (SQLException e) { System.out.println("Error when saving client in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    public Client update(Client entity) {

        try{

            var stmt = connect().prepareCall(UPDATE_CLIENT);
            stmt.setInt(1, entity.getId());
            stmt.setString(2, entity.getName());
            stmt.setString(3, entity.getLastname());
            stmt.setString(4, entity.getEmail());
            stmt.setString(5, entity.getPhone_number());
            stmt.executeQuery();

            return(entity);

        } catch (SQLException e) { System.out.println("Error when updating client in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    public void delete(Integer id) {

        try{

            var stmt = connect().prepareCall(DELETE_CLIENT);
            stmt.setInt(1, id);
            stmt.executeUpdate();

        } catch (SQLException e) { System.out.println("Error when deleting client in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }
}