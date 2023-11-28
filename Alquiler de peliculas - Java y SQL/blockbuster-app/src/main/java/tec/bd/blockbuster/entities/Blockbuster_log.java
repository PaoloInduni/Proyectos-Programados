package tec.bd.blockbuster.entities;

import java.util.Date;

public class Blockbuster_log {
    
    private int id;
    private String table_name;
    private Date created_on;
    private String entry_text;

    public Blockbuster_log(int id, String table_name, Date created_on, String entry_text) {
        this.id = id;
        this.table_name = table_name;
        this.created_on = created_on;
        this.entry_text = entry_text;
    }
    
    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
    public String getTable_name() {
        return table_name;
    }
    public void setTable_name(String table_name) {
        this.table_name = table_name;
    }
    public Date getCreated_on() {
        return created_on;
    }
    public void setCreated_on(Date created_on) {
        this.created_on = created_on;
    }
    public String getEntry_text() {
        return entry_text;
    }
    public void setEntry_text(String entry_text) {
        this.entry_text = entry_text;
    }
}