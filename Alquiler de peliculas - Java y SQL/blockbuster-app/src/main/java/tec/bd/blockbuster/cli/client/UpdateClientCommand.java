package tec.bd.blockbuster.cli.client;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Client;

import picocli.CommandLine;
import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.concurrent.Callable;


@Command(name = "cliu", description = "Update client data in catalog ")
public class UpdateClientCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(UpdateClientCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @CommandLine.Parameters(paramLabel = "<client id>", description = "The client id")
    private int clientId;

    @Parameters(paramLabel = "<name>", description = "The client name")
    private String clientName;
    @Parameters(paramLabel = "<lastName", description = "The client lastname")
    private String clientLastName;
    @Parameters(paramLabel = "<email>", description = "The client email")
    private String clientEmail;
    @Parameters(paramLabel = "<phoneNumber>", description = "The client phone number", defaultValue = "")
    private String clientPhoneNumber;

    @Override
    public Integer call() throws Exception {

        var client = new Client(clientId, clientName, clientLastName, clientEmail, clientPhoneNumber);
        
        try {

            var newclient = applicationContext.blockbusterService.updateClient(client);

            System.out.println(
                "ID: " + newclient.getId()
                +" Name: " + newclient.getName()
                +" Lastname: " + newclient.getLastname()
                +" Email: " + newclient.getEmail()
                +" Phone number: " + newclient.getPhone_number());

            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}
