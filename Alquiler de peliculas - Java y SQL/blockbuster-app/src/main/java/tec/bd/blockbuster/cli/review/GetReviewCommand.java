package tec.bd.blockbuster.cli.review;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Review;

import picocli.CommandLine;


@CommandLine.Command(name = "revr", description = "Get review in catalog by id")
public class GetReviewCommand implements Runnable {

    private static ApplicationContext applicationContext = ApplicationContext.init();
    @CommandLine.Parameters(paramLabel = "<review id>", description = "The review id", defaultValue = "")
    private String reviewId;

    @Override
    public void run() {
        
        if(reviewId.equals("")){
            var review = applicationContext.blockbusterService.getReview();

            System.out.println("Reviews: ");
            int i = 0;
            
            for(Review r : review) {
                System.out.println("========"+(i+1)+"========");
                System.out.println(
                    "ID: "+r.getId() 
                    +" Client ID: "+ r.getClient_id() 
                    +" Movie ID: " + r.getMovie_id() 
                    +" Review Rating: " + r.getRating() 
                    +" Review Text: " + r.getReview_text() 
                    +" Review Date: " + r.getCreated_on());
                    i+=1;
        }
        }else{
            applicationContext.blockbusterService.getReviewById(Integer.parseInt(reviewId)).ifPresentOrElse((review) -> {
            System.out.println(
                "ID: " + review.getId()
                +" Movie Id: " + review.getMovie_id()
                +" Client Id: " + review.getClient_id()
                +" Review rating: " + review.getRating()
                +" Review text: " + review.getReview_text()
                + "Created on: " + review.getCreated_on());
            }, () -> System.out.println("review id " + reviewId + " not found"));
        }
    }
}