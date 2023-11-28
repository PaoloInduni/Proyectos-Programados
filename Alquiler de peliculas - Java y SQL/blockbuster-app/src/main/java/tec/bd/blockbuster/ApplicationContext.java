package tec.bd.blockbuster;

import tec.bd.blockbuster.repository.*;
import tec.bd.blockbuster.services.*;

import com.zaxxer.hikari.HikariConfig;
import com.zaxxer.hikari.HikariDataSource;


public class ApplicationContext {

    public ClientRepository clientRepository;
    public CategoryRepository categoryRepository;
    public MovieRepository movieRepository;
    public ReviewRepository reviewRepository;
    public RentalRepository rentalsRepository;
    public BlockbusterLogRepository blockbusterLogRepository;
    public BlockbusterService blockbusterService;

    private ApplicationContext() {

    }

    public static ApplicationContext init() {
        ApplicationContext appContext = new ApplicationContext();

        var hikariConfig = initHikariDataSource();

        appContext.clientRepository = initClientRepository(hikariConfig);
        appContext.categoryRepository = initCategoryRepository(hikariConfig);
        appContext.movieRepository = initMovieRepository(hikariConfig);
        appContext.reviewRepository = initReviewRepository(hikariConfig);
        appContext.rentalsRepository = initRentalsRepository(hikariConfig);
        appContext.blockbusterLogRepository = initBlockbusterLogRepository(hikariConfig);
        appContext.blockbusterService = initBlockbusterService(appContext.movieRepository, appContext.categoryRepository,
                                        appContext.clientRepository, appContext.rentalsRepository, appContext.reviewRepository, 
                                        appContext.blockbusterLogRepository);

        return appContext;
    }

    private static HikariDataSource initHikariDataSource() {
        HikariConfig hikariConfig = new HikariConfig();

        hikariConfig.setJdbcUrl("jdbc:mysql://localhost:3306/blockbuster");
        hikariConfig.setUsername("blockbusterappuser");
        hikariConfig.setPassword("blockbusterapppass");
        hikariConfig.addDataSourceProperty("connectionTestQuery", "SELECT 1");
        hikariConfig.addDataSourceProperty("maximumPoolSize", "4");
        hikariConfig.addDataSourceProperty("cachePrepStmts", "true");
        hikariConfig.addDataSourceProperty("prepStmtCacheSize", "250");
        hikariConfig.addDataSourceProperty("prepStmtCacheSqlLimit", "2048");

        return new HikariDataSource(hikariConfig);
    }

    private static MovieRepository initMovieRepository(HikariDataSource hikariDataSource) {
        return new MovieRepositoryImpl(hikariDataSource);
    }
    private static CategoryRepository initCategoryRepository(HikariDataSource hikariDataSource) {
        return new CategoryRepositoryImpl(hikariDataSource);
    }
    private static RentalRepository initRentalsRepository(HikariDataSource hikariDataSource) {
        return new RentalRepositoryImpl(hikariDataSource);
    }
    private static ClientRepository initClientRepository(HikariDataSource hikariDataSource) {
        return new ClientRepositoryImpl(hikariDataSource);
    }
    private static ReviewRepository initReviewRepository(HikariDataSource hikariDataSource) {
        return new ReviewRepositoryImpl(hikariDataSource);
    }
    private static BlockbusterLogRepository initBlockbusterLogRepository(HikariDataSource hikariDataSource) {
        return new BlockbusterLogRepositoryImpl(hikariDataSource);
    }

    private static BlockbusterService initBlockbusterService(MovieRepository movieRepository, CategoryRepository categoryRepository,
            ClientRepository clientRepository, RentalRepository rentalsRepository, ReviewRepository reviewRepository,
            BlockbusterLogRepository blockbusterLogRepository) {
        return new BlockbusterServiceImpl(movieRepository, categoryRepository, clientRepository, rentalsRepository, reviewRepository, blockbusterLogRepository);
    }

}
