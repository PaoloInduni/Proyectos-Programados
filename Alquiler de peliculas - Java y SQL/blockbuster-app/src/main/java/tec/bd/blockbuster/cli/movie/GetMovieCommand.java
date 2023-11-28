package tec.bd.blockbuster.cli.movie;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Movie;
import picocli.CommandLine;


@CommandLine.Command(name = "movr", description = "Get movie in catalog")
public class GetMovieCommand implements Runnable {

    private static ApplicationContext applicationContext = ApplicationContext.init();
    @CommandLine.Parameters(paramLabel = "<movie id>", description = "The movie id", defaultValue = "")
    private String movieId;

    @Override
    public void run() {
        if(movieId.equals("")){
            var movies = applicationContext.blockbusterService.getMovies();

            System.out.println("Movies:");

            int i = 0;

            for(Movie m : movies) {
                System.out.println("========"+(i+1)+"========");
                System.out.println(
                    "ID: "+m.getId() 
                    + " Title: "+ m.getTitle() 
                    + " Release Date: " + m.getRelease_date() 
                    + " Category: " + m.getCategory_id());
                    i+=1;
            }
        }else{
            applicationContext.blockbusterService.getMovieById(Integer.parseInt(movieId)).ifPresentOrElse((movie) -> {
            System.out.println(
            "Movie Id: " + movie.getId()
            +" Title: " + movie.getTitle()
            +" Release Date: " + movie.getRelease_date()
            +" Category: " + movie.getCategory_id());
            }, () -> System.out.println("Movie id " + movieId + " not found"));
        }
            

    }
}