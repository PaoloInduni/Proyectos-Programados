package tec.bd.blockbuster.cli.category;

import tec.bd.blockbuster.ApplicationContext;

import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.concurrent.Callable;


@Command(name = "catd", description = "Delete category in catalog")
public class DeleteCategoryCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(DeleteCategoryCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @Parameters(paramLabel = "<category id>", description = "The id of the category we want to delete")
    private int categoryId;

    @Override
    public Integer call() throws Exception {
        try {

            applicationContext.blockbusterService.removeCategory(categoryId);
            System.out.println("The category " + categoryId + " was deleted sucessfully.");

            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}
