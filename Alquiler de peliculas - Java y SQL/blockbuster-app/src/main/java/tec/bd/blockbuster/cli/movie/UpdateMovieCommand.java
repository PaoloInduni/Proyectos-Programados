package tec.bd.blockbuster.cli.movie;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Movie;

import picocli.CommandLine;
import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.Date;
import java.util.concurrent.Callable;


@Command(name = "movu", description = "Update movie data in catalog ")
public class UpdateMovieCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(UpdateMovieCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @CommandLine.Parameters(paramLabel = "<movie id>", description = "The movie id")
    private int movieId;
    @Parameters(paramLabel = "<title>", description = "The movie title")
    private String movieTitle;
    @Parameters(paramLabel = "<release date>", description = "Release date")
    private Date movieReleaseDate;
    @Parameters(paramLabel = "<category id>", description = "The movie category id")
    private int movieCategoryId;
    @Parameters(paramLabel = "<units avaliable>", description = "Amount of Units avaliable")
    private int movieUnitsAvaliable;


    @Override
    public Integer call() throws Exception {

        var movie = new Movie(movieId, movieTitle, movieReleaseDate, movieUnitsAvaliable, movieCategoryId);
        
        try {

            var newmovie = applicationContext.blockbusterService.updateMovie(movie);

            System.out.println(
            "Movie Id: " + newmovie.getId()
            +" Title: " + newmovie.getTitle()
            +" Release Date: " + newmovie.getRelease_date()
            +" Category: " + newmovie.getCategory_id()
            +" Units Available: "+ newmovie.getUnits_available());

            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}
