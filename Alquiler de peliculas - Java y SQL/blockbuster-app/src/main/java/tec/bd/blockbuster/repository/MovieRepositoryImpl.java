package tec.bd.blockbuster.repository;

import tec.bd.blockbuster.entities.Movie;

import java.sql.*;
import java.util.*;

import com.zaxxer.hikari.HikariDataSource;

import static tec.bd.blockbuster.repository.Queries.*;

public class MovieRepositoryImpl extends BaseRepository<Movie, Integer> implements MovieRepository {

    public MovieRepositoryImpl(HikariDataSource hikariDataSource) {
        super(hikariDataSource);
    }

    @Override
    protected Movie toEntity(ResultSet resultSet) throws SQLException {
        return new Movie(resultSet.getInt("id"),
                resultSet.getString("title"),
                resultSet.getDate("release_date"),
                resultSet.getInt("units_available"),
                resultSet.getInt("category_id"));
    }

    @Override
    public List<Movie> findAll() {
        try {

            var stmt = connect().prepareStatement(READ_ALL_MOVIES);

            return query(stmt);

        } catch (SQLException e) {
            e.printStackTrace();
        }
        return (null);
    }

    @Override
    public Optional<Movie> findById(Integer id) {
        try {

            var stmt = connect().prepareStatement(READ_MOVIE);
            stmt.setInt(1, id);

            return query(stmt).stream().findFirst();
            
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return (null);
    }

    @Override
    public Movie save(Movie entity) {
        try {

            var stmt = connect().prepareCall(CREATE_MOVIE);
            
                stmt.setString(1, entity.getTitle());
                stmt.setDate(2, new java.sql.Date(entity.getRelease_date().getTime()));
                stmt.setInt(3, entity.getCategory_id());
                stmt.setInt(4, entity.getUnits_available());
                stmt.executeUpdate();

        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
        return (entity);
    }

    @Override
    public Movie update(Movie entity) {
        try {

            var stmt = connect().prepareCall(UPDATE_MOVIE);
            stmt.setInt(1, entity.getId());
            stmt.setString(2, entity.getTitle());
            stmt.setDate(3, new java.sql.Date(entity.getRelease_date().getTime()));
            stmt.setInt(4, entity.getCategory_id());
            stmt.setInt(5, entity.getUnits_available());
            stmt.executeUpdate();

            return(entity);

        } catch (SQLException e) { System.out.println("Error when updating movie in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    public void delete(Integer id) {
        try (var conn = this.connect()) {

            conn.setAutoCommit(false);
            conn.setTransactionIsolation(Connection.TRANSACTION_SERIALIZABLE);

            Savepoint savepointOne = conn.setSavepoint("savepoint_one");

            try (PreparedStatement stmt = conn.prepareStatement(DELETE_MOVIE, PreparedStatement.RETURN_GENERATED_KEYS)) {

                stmt.setInt(1, id);
                stmt.executeUpdate();
                conn.commit();

            } catch (SQLException e) {
                try {
                    conn.rollback(savepointOne);
                } catch (Exception rex) {
                    throw new RuntimeException(rex);
                }
            }
        } catch (SQLException e) {
            throw new RuntimeException(e);
        }
    }
}