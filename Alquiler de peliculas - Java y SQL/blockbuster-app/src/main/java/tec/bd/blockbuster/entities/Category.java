package tec.bd.blockbuster.entities;

public class Category {

    private int id;
    private String name;
    private String description;
    
    public Category(int id, String name, String description) {
        this.id = id;
        this.name = name;
        this.description = description;
    }

    public int getId() {
        return id;
    }
    public void setId(int id) {
        this.id = id;
    }
    public String getName() {
        return name;
    }
    public void setName(String category_name) {
        this.name = category_name;
    }
    public String getDescription() {
        return description;
    }
    public void setDescription(String category_description) {
        this.description = category_description;
    }
}