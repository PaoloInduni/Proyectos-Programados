package tec.bd.blockbuster.repository;

import tec.bd.blockbuster.entities.Rental;

import java.sql.*;
import java.util.*;

import com.zaxxer.hikari.HikariDataSource;

import static tec.bd.blockbuster.repository.Queries.*;


public class RentalRepositoryImpl extends BaseRepository<Rental, Integer> implements RentalRepository {

    public RentalRepositoryImpl (HikariDataSource hikariDataSource) {
        super(hikariDataSource);
    }

    protected Rental toEntity(ResultSet resultSet) throws SQLException {
        return new Rental
        (
            resultSet.getInt("id"),
            resultSet.getInt("movie_id"),
            resultSet.getInt("client_id"),
            resultSet.getDate("rental_date")
        );
    }

    public List<Rental> findAll() {

        try {
        
            var stmt = connect().prepareCall(READ_ALL_RENTALS);

            return query(stmt);

        } catch (SQLException e) { System.out.println("Error while finding rentals in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    public Optional<Rental> findById(Integer id) {

        try {
            
            var stmt = connect().prepareCall(READ_RENTAL);
            stmt.setInt(1, id);

            return query(stmt).stream().findFirst();

        } catch (SQLException e) { System.out.println("Error while finding rental in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }


    public Rental save(Rental entity) {

        try{

            var stmt = connect().prepareCall(CREATE_RENTAL);
            stmt.setInt(1, entity.getMovie_id());
            stmt.setInt(2, entity.getClient_id());
            stmt.setDate(3, new java.sql.Date(entity.getRental_date().getTime()));
            stmt.registerOutParameter("p_new_rental", Types.INTEGER);
            stmt.executeQuery();
            var newRentalsId = stmt.getInt("p_new_rental");
            entity.setId(newRentalsId);

            return(entity);

        } catch (SQLException e) { System.out.println("Error while saving rental in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    public Rental update(Rental entity) {

        try{

            var stmt = connect().prepareCall(UPDATE_RENTAL);
            stmt.setInt(1, entity.getId());
            stmt.setDate(2, new java.sql.Date(entity.getRental_date().getTime()));
            stmt.setInt(3, entity.getClient_id());
            stmt.setInt(4, entity.getMovie_id());
            stmt.executeQuery();

            return(entity);

        } catch (SQLException e) { System.out.println("Error while updating rental in the BD  \n" + //
                ""+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    public void delete(Integer id) {

        try{

            var stmt = connect().prepareCall(DELETE_RENTAL);
            stmt.setInt(1, id);
            stmt.executeQuery();

        } catch (SQLException e) { System.out.println("Error while deleting rental in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }
}