package tec.bd.blockbuster.cli.client;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Client;

import picocli.CommandLine.Command;
import picocli.CommandLine.Parameters;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.concurrent.Callable;


@Command(name = "clic", description = "Create new client in catalog")
public class CreateClientCommand implements Callable<Integer> {

    private final static Logger LOGGER = LoggerFactory.getLogger(CreateClientCommand.class);

    private static ApplicationContext applicationContext = ApplicationContext.init();

    @Parameters(paramLabel = "<name>", description = "The client name")
    private String clientName;
    @Parameters(paramLabel = "<lastName>", description = "The client last name", defaultValue = "")
    private String clientLastname;
    @Parameters(paramLabel = "<email>", description = "The client email", defaultValue = "")
    private String clientEmail;
    @Parameters(paramLabel = "<phoneNumber>", description = "The client phone number", defaultValue = "")
    private String clientPhoneNumber;

    @Override
    public Integer call() throws Exception {

        var client = new Client(0, clientName, clientLastname, clientEmail, clientPhoneNumber);

        try {

            var newclient = applicationContext.blockbusterService.newClient(client);
            System.out.println(
                "ID: " + newclient.getId()
                +" Name: " + newclient.getName()
                +" Last name: " + newclient.getLastname()
                +" Email: " + newclient.getEmail()
                +" Phone number: " + newclient.getPhone_number());
            
            return 0;

        } catch (Exception e) {

            LOGGER.error(e.getMessage(), e);

            return -1;

        }
    }
}
