package tec.bd.blockbuster.entities;

import java.util.Date;

public class Movie {

    private int id;
    private String title;
    private Date release_date;
    private int units_available;
    private int category_id;

    public Movie(int id, String title, Date release_date, int units_available, int category_id) {
        this.id = id;
        this.title = title;
        this.release_date = release_date;
        this.units_available = units_available;
        this.category_id = category_id;
    }

    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
    public String getTitle() {
        return title;
    }
    public void setTitle(String title) {
        this.title = title;
    }
    public Date getRelease_date() {
        return release_date;
    }
    public void setRelease_date(java.sql.Date date) {
        this.release_date = date;
    }
    public int getUnits_available() {
        return units_available;
    }
    public void setUnits_available(int units_available) {
        this.units_available = units_available;
    }
    public int getCategory_id() {
        return category_id;
    }
    public void setCategory_id(int category_id) {
        this.category_id = category_id;
    }
}