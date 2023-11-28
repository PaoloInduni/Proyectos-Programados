package tec.bd.blockbuster.cli.category;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Category;

import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.concurrent.Callable;


@Command(name = "catc", description = "Create new category in DB ")
public class CreateCategoryCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(CreateCategoryCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @Parameters(paramLabel = "<name>", description = "Name of the category")
    private String categoryName;
    @Parameters(paramLabel = "<description>", description = "Description of the category", defaultValue = "")
    private String categoryDescription;


    @Override
    public Integer call() throws Exception {

        var category = new Category(0, categoryName, categoryDescription);

        try {

            var newCategory = applicationContext.blockbusterService.newCategory(category);

            System.out.println("ID: " + newCategory.getId()
            +" Name: " + newCategory.getName()
            +" Description: " + newCategory.getDescription());

            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}
