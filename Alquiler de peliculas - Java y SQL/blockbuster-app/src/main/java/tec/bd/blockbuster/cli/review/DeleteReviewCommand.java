package tec.bd.blockbuster.cli.review;

import tec.bd.blockbuster.ApplicationContext;

import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.concurrent.Callable;


@Command(name = "revd", description = "Delete review in catalog ")
public class DeleteReviewCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(DeleteReviewCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @Parameters(paramLabel = "<review id>", description = "The id of the review we want to delete")
    private int reviewId;

    @Override
    public Integer call() throws Exception {
        try {

            applicationContext.blockbusterService.removeReview(reviewId);
            System.out.println("The review " + reviewId + " was deleted sucessfully.");
            
            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}
