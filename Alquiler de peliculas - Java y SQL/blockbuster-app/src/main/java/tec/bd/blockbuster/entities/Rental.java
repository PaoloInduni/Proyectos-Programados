package tec.bd.blockbuster.entities;

import java.util.Date;

public class Rental {

    private int id;
    private Date rental_date;
    private int client_id;
    private int movie_id;
    
    public Rental(int id, int movie_id, int client_id, Date rental_date) {
        this.id = id;
        this.rental_date = rental_date;
        this.client_id = client_id;
        this.movie_id = movie_id;
    }

    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
    public Date getRental_date() {
        return rental_date;
    }
    public void setRental_date(Date rental_date) {
        this.rental_date = rental_date;
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