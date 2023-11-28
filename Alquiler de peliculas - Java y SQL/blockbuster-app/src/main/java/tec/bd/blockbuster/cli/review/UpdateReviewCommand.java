package tec.bd.blockbuster.cli.review;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Review;

import picocli.CommandLine;
import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.Date;
import java.util.concurrent.Callable;

@Command(name = "revu", description = "Update review data in catalog")
public class UpdateReviewCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(UpdateReviewCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @CommandLine.Parameters(paramLabel = "<review id>", description = "The review id")
    private int reviewId;
    @Parameters(paramLabel = "<movieId>", description = "The movie id")
    private int movieId;
    @Parameters(paramLabel = "<clientId>", description = "The client id")
    private int clientId;
    @Parameters(paramLabel = "<reviewRating>", description = "The review rating")
    private int reviewRating;
    @Parameters(paramLabel = "<reviewtext>", description = "The review text", defaultValue = "")
    private String reviewtext;
    @Parameters(paramLabel = "<createdOn>", description = "The review date")
    private Date createdOn;

    @Override
    public Integer call() throws Exception {

        var review = new Review(reviewId, movieId, clientId, reviewRating, reviewtext, createdOn);
        
        try {
            var newreview = applicationContext.blockbusterService.updateReview(review);

            System.out.println(

                "Review ID: " + newreview.getId()
                +" Movie ID: " + newreview.getMovie_id()
                +" Client ID: " + newreview.getClient_id()
                +" Review rating: " + newreview.getRating()
                +" Review text: " + newreview.getReview_text()
                +" Created on: " + newreview.getCreated_on());

            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}
