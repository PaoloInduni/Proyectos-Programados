package tec.bd.blockbuster.cli.client;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Client;

import picocli.CommandLine;


@CommandLine.Command(name = "clir", description = "Get client in catalog by id")
public class GetClientCommand implements Runnable {

    private static ApplicationContext applicationContext = ApplicationContext.init();
    @CommandLine.Parameters(paramLabel = "<client id>", description = "The client id", defaultValue = "")
    private String clientId;

    @Override
    public void run() {
        
        if(clientId.equals("")){
            var client = applicationContext.blockbusterService.getClient();

            System.out.println("Clients");
            int i = 0;

            for(Client m : client) {
                System.out.println("========"+(i+1)+"========");
                System.out.println(
                    "ID: "+m.getId()
                    +" Name: "+ m.getName()
                    +" Last name: " + m.getLastname() 
                    +" Email: " + m.getEmail() 
                    +" Phone number: " + m.getPhone_number());
                    i+=1;
            }
        }else{
            applicationContext.blockbusterService.getClientById(Integer.parseInt(clientId)).ifPresentOrElse((client) -> {
            System.out.println(
                "ID: " + client.getId()
                +" Name: " + client.getName()
                +" Lastname: " + client.getLastname()
                +" Email: " + client.getEmail()
                +" Phone number: " + client.getPhone_number());
            }, () -> System.out.println("client id " + clientId + " not found"));
        }
            

    }
}
