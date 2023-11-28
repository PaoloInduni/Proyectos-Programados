package tec.bd.blockbuster.services;

import tec.bd.blockbuster.entities.*;
import tec.bd.blockbuster.repository.*;

import java.util.*;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import static java.util.Objects.requireNonNull;

public class BlockbusterServiceImpl implements BlockbusterService {

    private final static Logger LOGGER = LoggerFactory.getLogger(BlockbusterServiceImpl.class);

    private final MovieRepository movieRepository;
    private final CategoryRepository categoryRepository;
    private final ClientRepository clientRepository;
    private final RentalRepository rentalsRepository;
    private final ReviewRepository reviewRepository;
    private final BlockbusterLogRepository blockbusterLogRepository;

    public BlockbusterServiceImpl(MovieRepository movieRepository, CategoryRepository categoryRepository,ClientRepository clientRepository, RentalRepository rentalsRepository, ReviewRepository reviewRepository,BlockbusterLogRepository blockbusterLogRepository) {
        requireNonNull(movieRepository);
        requireNonNull(categoryRepository);

        this.movieRepository = movieRepository;
        this.categoryRepository = categoryRepository;
        this.clientRepository = clientRepository;
        this.rentalsRepository = rentalsRepository;
        this.reviewRepository = reviewRepository;
        this.blockbusterLogRepository = blockbusterLogRepository;
    }


    //Movie


    @Override
    public Movie newMovie(Movie movie) {
        requireNonNull(movie);
        requireNonNull(movie.getCategory_id());

        LOGGER.debug("Creating new movie via adhoc SQL commands");
        this.categoryRepository.findById(movie.getCategory_id()).orElseThrow();

        return this.movieRepository.save(movie);
    }

    @Override
    public void removeMovie(int movieId) {

        var movieInCatalog = this.movieRepository.findById(movieId);

        movieInCatalog.ifPresentOrElse((m) -> {

        this.movieRepository.delete(movieId);
            }, () -> {
                LOGGER.debug("Movie id {} doesnt exist in catalog", movieId);
                new RuntimeException("Movie doesnt exists in catalog");
            });
    }

    @Override
    public Movie updateMovie(Movie movie) {
        return this.movieRepository.update(movie);
    }

    @Override
    public List<Movie> getMovies() {
        return this.movieRepository.findAll();
    }

    @Override
    public Optional<Movie> getMovieById(int movieId) {
        if (movieId > 0) {

            return this.movieRepository.findById(movieId);
        }

        return Optional.empty();
    }


    //Category


     @Override
    public Category newCategory(Category category) {
        requireNonNull(category);

        LOGGER.debug("Creating new category via adhoc SQL commands");

        return this.categoryRepository.save(category);
    }

    @Override
    public void removeCategory(int categoryId) {

        var categoryInCatalog = this.categoryRepository.findById(categoryId);

        categoryInCatalog.ifPresentOrElse((m) -> {

        this.categoryRepository.delete(categoryId);
            }, () -> {
                LOGGER.debug("Category id {} doesnt exist in catalog", categoryId);
                new RuntimeException("Category doesnt exists in catalog");
            });

    }

    @Override
    public Category updateCategory(Category category) {
        return this.categoryRepository.update(category);
    }

    @Override
    public List<Category> getCategory() {
        return this.categoryRepository.findAll();
    }

    @Override
    public Optional<Category> getCategoryById(int categoryId) {
        if (categoryId > 0) {
            
            return this.categoryRepository.findById(categoryId);
        }

        return Optional.empty();
    }


    //Rental


    @Override
    public Rental newRental(Rental rental) {
        requireNonNull(rental);

        LOGGER.debug("Creating new rentals via adhoc SQL commands");

        return this.rentalsRepository.save(rental);
    }

    @Override
    public void removeRental(int rentalId) {

        var rentalsInCatalog = this.rentalsRepository.findById(rentalId);

        rentalsInCatalog.ifPresentOrElse((m) -> {

        this.rentalsRepository.delete(rentalId);
            }, () -> {
                LOGGER.debug("Rentals id {} doesnt exist in catalog", rentalId);
                new RuntimeException("Rentals doesnt exists in catalog");
            });
    }

    @Override
    public Rental updateRental(Rental rental) {
        return this.rentalsRepository.update(rental);
    }

    @Override
    public List<Rental> getRental() {
        return this.rentalsRepository.findAll();
    }

    @Override
    public Optional<Rental> getRentalById(int rentalId) {
        if (rentalId > 0) {

            return this.rentalsRepository.findById(rentalId);
        }

        return Optional.empty();
    }


    //Client


    @Override
    public Client newClient(Client client) {
        requireNonNull(client);

        LOGGER.debug("Creating new client via adhoc SQL commands");

        return this.clientRepository.save(client);
    }

    @Override
    public void removeClient(int clientId) {
        this.clientRepository.delete(clientId);
    }

    @Override
    public Client updateClient(Client client) {
        return this.clientRepository.update(client);
    }

    @Override
    public List<Client> getClient() {
        return this.clientRepository.findAll();
    }

    @Override
    public Optional<Client> getClientById(int clientId) {
        if (clientId > 0) {

            return this.clientRepository.findById(clientId);
        }

        return Optional.empty();
    }


    //Review

    
    @Override
    public Review newReview(Review review) {
        requireNonNull(review);

        LOGGER.debug("Creating new review via adhoc SQL commands");

        return this.reviewRepository.save(review);
    }

    @Override
    public void removeReview(int reviewId) {

        var reviewInCatalog = this.reviewRepository.findById(reviewId);

        reviewInCatalog.ifPresentOrElse((m) -> {

        this.reviewRepository.delete(reviewId);
            }, () -> {
                LOGGER.debug("Review id {} doesnt exist in catalog", reviewId);
                new RuntimeException("Review doesnt exists in catalog");
            });

    }

    @Override
    public Review updateReview(Review review) {
        return this.reviewRepository.update(review);
    }

        @Override
    public List<Review> getReview() {
        return this.reviewRepository.findAll();
    }

    @Override
    public Optional<Review> getReviewById(int reviewId) {
        if (reviewId > 0) {
            return this.reviewRepository.findById(reviewId);
        }

        return Optional.empty();
    }


    //Blockbuster log


    @Override
    public List<Blockbuster_log> getBlockbusterLog() {
        return this.blockbusterLogRepository.findAll();
    }
}
