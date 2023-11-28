package tec.bd.blockbuster;

import tec.bd.blockbuster.cli.MainCommand;

import picocli.CommandLine;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

public class App {
    private final static Logger LOGGER = LoggerFactory.getLogger(App.class);

    public static void main( String[] args ) {

        LOGGER.debug("Movie Catalog App: initializing... ");

        CommandLine cmd = new CommandLine(new MainCommand());
        cmd.setExecutionStrategy(new CommandLine.RunAll()); // default is RunLast
        cmd.execute(args);

        if (args.length == 0) {
            cmd.usage(System.out);
        }
    }
}