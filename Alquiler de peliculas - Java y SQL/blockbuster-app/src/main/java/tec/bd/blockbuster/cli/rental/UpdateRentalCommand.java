package tec.bd.blockbuster.cli.rental;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Rental;

import picocli.CommandLine;
import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.Date;
import java.util.concurrent.Callable;


@Command(name = "loanu", description = "Update rental data in catalog ")
public class UpdateRentalCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(UpdateRentalCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @CommandLine.Parameters(paramLabel = "<rentals id>", description = "The rental id")
    private int rentalsId;
    @Parameters(paramLabel = "<movieId>", description = "The movie id", defaultValue = "")
    private int MovieId;
    @Parameters(paramLabel = "<clientId>", description = "The client id", defaultValue = "")
    private int clientId;
    @Parameters(paramLabel = "<rentalDate>", description = "The rental date")
    private Date rentalsDate;

    @Override
    public Integer call() throws Exception {

        var rentals = new Rental(rentalsId, MovieId, clientId, rentalsDate);
        
        try {

            var newrentals = applicationContext.blockbusterService.updateRental(rentals);

            System.out.println(

                "Rental ID: " + newrentals.getId()
                +" Movie ID: " + newrentals.getMovie_id()
                +" Client ID: " + newrentals.getClient_id()
                +" Rental date " + newrentals.getRental_date());

            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);
            System.out.println("PLEASE MAKE SURE TO USE THIS FORMAT: id movie_id client_id date \\n");

            return -1;

        }
    }
}
