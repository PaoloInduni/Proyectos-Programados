package tec.bd.blockbuster.cli.blockbusterLog;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Blockbuster_log;

import picocli.CommandLine;

@CommandLine.Command(name = "log", description = "Get logs register in the DB")
public class GetBlockbusterLogCommand implements Runnable {

    private static ApplicationContext applicationContext = ApplicationContext.init();
    @CommandLine.Parameters(paramLabel = "<log amount>", description = "The amount of logs whe want to print", defaultValue = "")
    private String logAmount;

    @Override
    public void run() {

        int n = Integer.parseInt(logAmount);

        var blockbuster_log = applicationContext.blockbusterService.getBlockbusterLog();

        System.out.println("BB Logs:");
        int i = 0;

        for(Blockbuster_log bb : blockbuster_log) {
            System.out.println(
                "ID: "+ bb.getId()
                +" Table name: "+ bb.getTable_name()
                +" Created on: " + bb.getCreated_on()
                +" Entry text: " + bb.getEntry_text());
                i+=1;
            if(i==n){
                break;
            }
        }
    }
}