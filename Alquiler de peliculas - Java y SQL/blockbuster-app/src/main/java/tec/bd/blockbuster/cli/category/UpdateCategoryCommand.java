package tec.bd.blockbuster.cli.category;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Category;

import picocli.CommandLine;
import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.concurrent.Callable;

@Command(name = "catu", description = "Update category data in catalog")
public class UpdateCategoryCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(UpdateCategoryCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @CommandLine.Parameters(paramLabel = "<category id>", description = "The category id")
    private int categoryId;
    @Parameters(paramLabel = "<name>", description = "The category name")
    private String categoryName;
    @Parameters(paramLabel = "<description>", description = "The category description", defaultValue = "")
    private String categoryDescription;

    @Override
    public Integer call() throws Exception {

        var category = new Category(categoryId, categoryName, categoryDescription);
        
        try {

            var newcategory = applicationContext.blockbusterService.updateCategory(category);

            System.out.println(
                "ID: " + newcategory.getId()
                +" Name: " + newcategory.getName()
                +" Description: " + newcategory.getDescription());

            return 0;

        } catch (Exception e) {
            
            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}
