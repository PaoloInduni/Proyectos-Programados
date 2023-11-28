package tec.bd.blockbuster.cli.category;

import tec.bd.blockbuster.ApplicationContext;
import tec.bd.blockbuster.entities.Category;
import picocli.CommandLine;


@CommandLine.Command(name = "catr", description = "Get category in catalog by id")
public class GetCategoryCommand implements Runnable {

    private static ApplicationContext applicationContext = ApplicationContext.init();
    @CommandLine.Parameters(paramLabel = "<category id>", description = "The category id", defaultValue = "")
    private String categoryId;

    @Override
    public void run() {
        if(categoryId.equals("")){
            var category = applicationContext.blockbusterService.getCategory();

            System.out.println("Categories");
            int i = 0;

            for(Category m : category) {
                System.out.println("========"+(i+1)+"========");
                System.out.println(
                    "ID: "+m.getId() 
                    +" Name: "+ m.getName() 
                    +" Description: " + m.getDescription());
                    i+=1;
            }
        }else{
            applicationContext.blockbusterService.getCategoryById(Integer.parseInt(categoryId)).ifPresentOrElse((category) -> {
            System.out.println(
                " ID: " + category.getId()
                +" Name: " + category.getName()
                +" Description: " + category.getDescription());
            }, () -> System.out.println("Category id " + categoryId + " not found"));
        }
    }
}