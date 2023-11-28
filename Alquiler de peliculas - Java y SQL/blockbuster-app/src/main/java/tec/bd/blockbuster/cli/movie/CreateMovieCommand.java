package tec.bd.blockbuster.cli.movie;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Movie;

import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.Date;
import java.util.concurrent.Callable;


@Command(name = "movc", description = "Create new movie in DB")
public class CreateMovieCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(CreateMovieCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @Parameters(paramLabel = "<title>", description = "The movie title")
    private String movieTitle;
    @Parameters(paramLabel = "<release date>", description = "Release date")
    private Date movieReleaseDate;
    @Parameters(paramLabel = "<category id>", description = "The movie category id")
    private int movieCategoryId;
    @Parameters(paramLabel = "<units avaliable>", description = "Amount of units avaliable")
    private int movieUnitsAvaliable;

    @Override
    public Integer call() throws Exception {

        var movie = new Movie(0, movieTitle, movieReleaseDate, movieUnitsAvaliable, movieCategoryId);

        try {

            var newMovie = applicationContext.blockbusterService.newMovie(movie);

            System.out.println(
            " Title: " + newMovie.getTitle()
            +" Release Date: " + newMovie.getRelease_date()
            +" Category: " + newMovie.getCategory_id()
            +" Units avaliable: " + newMovie.getUnits_available());

            return 1;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}