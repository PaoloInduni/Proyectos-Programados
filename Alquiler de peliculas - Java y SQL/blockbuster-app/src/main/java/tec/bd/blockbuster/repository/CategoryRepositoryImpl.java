package tec.bd.blockbuster.repository;

import tec.bd.blockbuster.entities.Category;

import java.sql.*;
import java.util.*;

import com.zaxxer.hikari.HikariDataSource;

import static tec.bd.blockbuster.repository.Queries.*;

public class CategoryRepositoryImpl extends BaseRepository<Category, Integer> implements CategoryRepository {


    public CategoryRepositoryImpl(HikariDataSource hikariDataSource) {
        super(hikariDataSource);
    }

    
    @Override
    public List<Category> findAll() {

        try {
        
            var stmt = connect().prepareCall(READ_ALL_CATEGORIES);

            return query(stmt);

        } catch (SQLException e) { System.out.println("Error when finding categories in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    public Optional<Category> findById(Integer id) {

        try {
            
            var stmt = connect().prepareCall(READ_CATEGORY);
            stmt.setInt(1, id);

            return query(stmt).stream().findFirst();

        } catch (SQLException e) { System.out.println("Error when finding category in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }


    public Category save(Category entity) {

        try{

            var stmt = connect().prepareCall(CREATE_CATEGORY);

            stmt.setString(1, entity.getName());
            stmt.setString(2, entity.getDescription());
            stmt.registerOutParameter("p_new_category_id", Types.INTEGER);
            stmt.executeQuery();

            var newCategoryId = stmt.getInt("p_new_category_id");
            entity.setId(newCategoryId);

            return(entity);
        
        } catch (SQLException e) { System.out.println("Error while save category in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }

    }

    public Category update(Category entity) {

        try{

            var stmt = connect().prepareCall(UPDATE_CATEGORY);
            stmt.setInt(1, entity.getId());
            stmt.setString(2, entity.getName());
            stmt.setString(3, entity.getDescription());
            stmt.executeQuery();

            return(entity);

        } catch (SQLException e) { System.out.println("Error while update category in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    public void delete(Integer id) {

        try{

            var stmt = connect().prepareCall(DELETE_CATEGORY);
            stmt.setInt(1, id);
            stmt.executeUpdate();

        } catch (SQLException e) { System.out.println("Error while delete category in the BD  \n "+e.getMessage()); throw new RuntimeException(e); }
    }

    @Override
    protected Category toEntity(ResultSet resultSet) throws SQLException {
        return new Category(
            resultSet.getInt("id"),
            resultSet.getString("name"),
            resultSet.getString("description")
        );
    }
}
