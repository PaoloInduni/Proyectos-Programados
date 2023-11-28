package tec.bd.blockbuster.cli.rental;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Rental;

import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.Date;
import java.util.concurrent.Callable;


@Command(name = "loanc", description = "Create new rental in DB ")
public class CreateRentalCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(CreateRentalCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @Parameters(paramLabel = "<movieId>", description = "The movie id")
    private int MovieId;
    @Parameters(paramLabel = "<clientId>", description = "The cleint id")
    private int clientId;
    @Parameters(paramLabel = "<rental_date>", description = "The rental date")
    private Date rental_date;


    @Override
    public Integer call() throws Exception {

        var rental = new Rental(0, MovieId, clientId, rental_date);

        try {

            var newRental = applicationContext.blockbusterService.newRental(rental);

            System.out.println(

                "Rental ID: " + newRental.getId()
                +" Movie ID: " + newRental.getMovie_id()
                +" Client ID: " + newRental.getClient_id()
                +" Rental date " + newRental.getRental_date());

            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}