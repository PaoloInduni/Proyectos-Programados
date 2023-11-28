package tec.bd.blockbuster.services;

import tec.bd.blockbuster.entities.*;

import java.util.*;

public interface BlockbusterService {

    //Movie

    List<Movie> getMovies();
    Optional<Movie> getMovieById(int movieId);
    Movie newMovie(Movie movie);
    void removeMovie(int movieId);
    Movie updateMovie(Movie movie);

    //Category

    List<Category> getCategory();
    Optional<Category> getCategoryById(int categoryId);
    Category newCategory(Category category);
    void removeCategory(int categoryId);
    Category updateCategory(Category category);

    //Client

    List<Client> getClient();
    Optional<Client> getClientById(int clientId);
    Client newClient(Client client);
    void removeClient(int clientId);
    Client updateClient(Client client);

    //Review

    List<Review> getReview();
    Optional<Review> getReviewById(int reviewId);
    Review newReview(Review review);
    void removeReview(int reviewId);
    Review updateReview(Review review);

    //Rental

    List<Rental> getRental();
    Optional<Rental> getRentalById(int rentalId);
    Rental newRental(Rental rental);
    void removeRental(int rentalId);
    Rental updateRental(Rental rental);

    //Blocbuster log

    List<Blockbuster_log> getBlockbusterLog();

}