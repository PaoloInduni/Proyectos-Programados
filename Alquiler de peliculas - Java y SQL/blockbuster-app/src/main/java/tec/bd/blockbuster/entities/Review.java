package tec.bd.blockbuster.entities;

import java.util.Date;

public class Review {

    private int id;
    private int rating;
    private String review_text;
    private Date created_on;
    private int client_id;
    private int movie_id;

    public Review(int id, int movie_id, int client_id, int rating, String review_text, Date created_on) {
        this.id = id;
        this.rating = rating;
        this.review_text = review_text;
        this.created_on = created_on;
        this.client_id = client_id;
        this.movie_id = movie_id;
    }
    
    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
    public int getRating() {
        return rating;
    }
    public void setRating(int rating) {
        this.rating = rating;
    }
    public String getReview_text() {
        return review_text;
    }
    public void setReview_text(String review_text) {
        this.review_text = review_text;
    }
    public Date getCreated_on() {
        return created_on;
    }
    public void setCreated_on(Date created_on) {
        this.created_on = created_on;
    }
    public int getClient_id() {
        return client_id;
    }
    public void setClient_id(int client_id) {
        this.client_id = client_id;
    }
    public int getMovie_id() {
        return movie_id;
    }
    public void setMovie_id(int movie_id) {
        this.movie_id = movie_id;
    }
}