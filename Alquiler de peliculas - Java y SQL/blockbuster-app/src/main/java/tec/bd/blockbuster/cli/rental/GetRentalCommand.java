package tec.bd.blockbuster.cli.rental;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Rental;
import picocli.CommandLine;


@CommandLine.Command(name = "loanr", description = "Get rental in catalog by id")
public class GetRentalCommand implements Runnable {

    private static ApplicationContext applicationContext = ApplicationContext.init();
    @CommandLine.Parameters(paramLabel = "<rental id>", description = "The rental id", defaultValue = "")
    private String rentalId;

    @Override
    public void run() {
        if(rentalId.equals("")){
            var rental = applicationContext.blockbusterService.getRental();

            System.out.println("rental:");
            int i = 0;

            for(Rental r : rental) {
                System.out.println("========"+(i+1)+"========");
                System.out.println(
                    "ID: " + r.getId()
                    +" Movie ID: " + r.getMovie_id()
                    +" Client ID: " + r.getId()
                    +" Rental date: " + r.getRental_date());
                    i+=1;
            }
        }else{
            applicationContext.blockbusterService.getRentalById(Integer.parseInt(rentalId)).ifPresentOrElse((rental) -> {
            System.out.println(
                "ID: " + rental.getId()
                +" Movie ID: " + rental.getMovie_id()
                +" Client ID: " + rental.getId()
                +" Rental date: " + rental.getRental_date());
            }, () -> System.out.println("rental id " + rentalId + " not found"));
        }
            
    }
}