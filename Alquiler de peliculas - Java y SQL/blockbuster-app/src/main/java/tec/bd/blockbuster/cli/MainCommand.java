package tec.bd.blockbuster.cli;

import tec.bd.blockbuster.cli.blockbusterLog.GetBlockbusterLogCommand;
import tec.bd.blockbuster.cli.category.*;
import tec.bd.blockbuster.cli.client.*;
import tec.bd.blockbuster.cli.movie.*;
import tec.bd.blockbuster.cli.rental.*;
import tec.bd.blockbuster.cli.review.*;

import picocli.CommandLine.Command;
import picocli.CommandLine.HelpCommand;

@Command(

        name = "blockbuster-app",
        subcommands = {
                GetMovieCommand.class,
                CreateMovieCommand.class,
                DeleteMovieCommand.class,
                UpdateMovieCommand.class,

                GetCategoryCommand.class,
                CreateCategoryCommand.class,
                DeleteCategoryCommand.class,
                UpdateCategoryCommand.class,

                GetClientCommand.class,
                CreateClientCommand.class,
                DeleteClientCommand.class,
                UpdateClientCommand.class,
                
                GetRentalCommand.class,
                CreateRentalCommand.class,
                DeleteRentalCommand.class,
                UpdateRentalCommand.class,

                GetReviewCommand.class,
                CreateReviewCommand.class,
                DeleteReviewCommand.class,
                UpdateReviewCommand.class,
                
                GetBlockbusterLogCommand.class,

                HelpCommand.class
        },
        description = "blockbuster-app")
        
public class MainCommand implements Runnable {

    @Override
    public void run() {

    }
}
