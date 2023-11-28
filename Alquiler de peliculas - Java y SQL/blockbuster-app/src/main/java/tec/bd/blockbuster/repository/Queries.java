package tec.bd.blockbuster.repository;

public class Queries {

        //Movie

        public static final String CREATE_MOVIE = "INSERT INTO movie(title, release_date, category_id, units_available) VALUES(?, ?, ?, ?)";
        public static final String READ_ALL_MOVIES = "SELECT * FROM movie";
        public static final String READ_MOVIE = "SELECT * FROM movie WHERE movie.id = ?";
        public static final String UPDATE_MOVIE = "UPDATE movie SET title = ?, release_date = ?, category_id = ?, units_available = ? WHERE movie.id = ?";
        public static final String DELETE_MOVIE = "DELETE FROM movie WHERE movie.id = ?";
        
        public static final String MOVIE_RENTALS = "SELECT COUNT(*) FROM rentals WHERE movie_id = ?";
        public static final String MOVIE_REVIEW = "SELECT COUNT(*) FROM reviews WHERE movie_id = ?";

        //Category

        public static final String CREATE_CATEGORY = "{ CALL create_category(?, ?, ?) }";
        public static final String READ_ALL_CATEGORIES = "{ CALL read_all_category() }";
        public static final String READ_CATEGORY = "{ CALL read_category(?,?) }";
        public static final String UPDATE_CATEGORY = "{ CALL update_category(?, ?, ?, ?) }";
        public static final String DELETE_CATEGORY = "{ CALL delete_category(?,?) }";

        //Rental

        public static final String CREATE_RENTAL = "{ CALL create_rental(?, ?, ?, ?) }";
        public static final String READ_ALL_RENTALS = "{ CALL read_all_rental() }";
        public static final String READ_RENTAL = "{ CALL read_rental(?,?) }";
        public static final String UPDATE_RENTAL = "{ CALL update_rental(?, ?, ?, ?, ?) }";
        public static final String DELETE_RENTAL = "{ CALL delete_rental(?,?) }";

        //Client
        
        public static final String CREATE_CLIENT = "{ CALL create_client(?, ?, ?, ?, ?) }";
        public static final String READ_ALL_CLIENTS = "{ CALL read_all_client() }";
        public static final String READ_CLIENT = "{ CALL read_client(?, ?) }";
        public static final String UPDATE_CLIENT = "{ CALL update_client(?, ?, ?, ?, ?, ?) }";
        public static final String DELETE_CLIENT = "{ CALL delete_client(?,?) }";

        //Review

        public static final String CREATE_REVIEW = "{ CALL create_review(?, ?, ?, ?, ?, ?) }";
        public static final String READ_ALL_REVIEWS = "{ CALL read_all_review() }";
        public static final String READ_REVIEW = "{ CALL read_review(?,?) }";
        public static final String UPDATE_REVIEW = "{ CALL update_review(?, ?, ?, ?, ?, ?) }";
        public static final String DELETE_REVIEW = "{ CALL delete_review(?,?) }";

        //Blockbuster_log

        public static final String READ_ALL_BB_LOGS = "{ CALL read_all_log() }";
        public static final String READ_LOG = "SELECT id, table_name, created_on, entry_text from blockbuster_log order by created_on desc limit ?";
    }