package tec.bd.blockbuster.cli.rental;

import tec.bd.blockbuster.ApplicationContext;

import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.concurrent.Callable;


@Command(name = "loand", description = "Delete rental in catalog ")
public class DeleteRentalCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(DeleteRentalCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @Parameters(paramLabel = "<rental id>", description = "Id of the rental we want to delete")
    private int rentalsId;


    @Override
    public Integer call() throws Exception {
        try {

            applicationContext.blockbusterService.removeRental(rentalsId);
            System.out.println("The rental " + rentalsId + " was deleted sucessfully.");

            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}
