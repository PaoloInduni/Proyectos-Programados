package tec.bd.blockbuster.repository;

import tec.bd.blockbuster.entities.Review;

import java.sql.*;
import java.util.*;

import com.zaxxer.hikari.HikariDataSource;

import static tec.bd.blockbuster.repository.Queries.*;


public class ReviewRepositoryImpl extends BaseRepository<Review, Integer> implements ReviewRepository {

    public ReviewRepositoryImpl (HikariDataSource hikariDataSource) {
        super(hikariDataSource);
    }

    protected Review toEntity(ResultSet resultSet) throws SQLException {
        return new Review
        (
            resultSet.getInt("id"),
            resultSet.getInt("movie_id"),
            resultSet.getInt("client_id"),
            resultSet.getInt("rating"),
            resultSet.getString("review_text"),
            resultSet.getDate("created_on")
        );
    }

    public List<Review> findAll() {

        try {
        
            var stmt = connect().prepareCall(READ_ALL_REVIEWS);

            return query(stmt);

        } catch (SQLException e) { System.out.println("Error while finding reviews in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    public Optional<Review> findById(Integer id) {

        try {
            
            var stmt = connect().prepareCall(READ_REVIEW);
            stmt.setInt(1, id);

            return query(stmt).stream().findFirst();

        } catch (SQLException e) { System.out.println("Error while finding review in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }


    public Review save(Review entity) {

        try{

            var stmt = connect().prepareCall(CREATE_REVIEW);
            stmt.setInt(1, entity.getMovie_id());
            stmt.setInt(2, entity.getClient_id());
            stmt.setInt(3, entity.getRating());
            stmt.setString(4, entity.getReview_text());
            stmt.setDate(5, new java.sql.Date(entity.getCreated_on().getTime()));
            
            stmt.registerOutParameter("p_new_review", Types.INTEGER);
            stmt.executeQuery();

            var newReviewId = stmt.getInt("p_new_review");
            entity.setId(newReviewId);

            return(entity);

        } catch (SQLException e) { System.out.println("Error while saving review in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    public Review update(Review entity) {

        try{

            var stmt = connect().prepareCall(UPDATE_REVIEW);
            stmt.setInt(1, entity.getId());
            stmt.setInt(2, entity.getMovie_id());
            stmt.setInt(3, entity.getClient_id());
            stmt.setInt(4, entity.getRating());
            stmt.setString(5, entity.getReview_text());
            stmt.setDate(6, (java.sql.Date) entity.getCreated_on());
            
            
            stmt.executeQuery();

            return(entity);

        } catch (SQLException e) { System.out.println("Error while updating review in the BD  \n Please make sure to use this format: id movie_id client_id review_rating review_text created_on \n"+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    public void delete(Integer id) {

        try{

            var stmt = connect().prepareCall(DELETE_REVIEW);
            stmt.setInt(1, id);
            stmt.executeQuery();

        } catch (SQLException e) { System.out.println("Error while deleting review in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }
}