package tec.bd.blockbuster.cli.movie;

import tec.bd.blockbuster.ApplicationContext;

import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.concurrent.Callable;


@Command(name = "movd", description = "Delete movie in catalog ")
public class DeleteMovieCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(DeleteMovieCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @Parameters(paramLabel = "<movie id>", description = "The movie id to be deleted")
    private int movieId;

    @Override
    public Integer call() throws Exception {
        try {

            applicationContext.blockbusterService.removeMovie(movieId);
            System.out.println("The movie " + movieId + " was deleted sucessfully.");

            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}
