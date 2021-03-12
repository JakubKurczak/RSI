import java.awt.*;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.*;
import java.util.List;

public class properVector {
    private static Map<String, List<String>> function_arguments;

    public static void setMap(String s){
        properVector.function_arguments = new HashMap<String,List<String>>();
        List<String> l_string = Arrays.asList(s.split("#"));
        for(String single_f: l_string){
            if(single_f.length() > 0){
                List<String> single_f_lines = Arrays.asList(single_f.split("\\r?\\n"));
                //first line is our function name
                //second includes function characteristics
                List<String> arguments = Arrays.asList(single_f_lines.get(1).split("=>")[0].split(","));
                for(int ii=0;ii<arguments.size();ii++){
                    String a = arguments.get(ii).replaceAll("\\s","");
                    if(!a.equals(arguments.get(ii))){
                        arguments.set(ii,a);
                    }
                }


                properVector.function_arguments.put(single_f_lines.get(0),arguments);
            }
        }
    }

    public static Vector<Object> getProperVector(List<String> values,String funcName){
        Vector<Object> objects = new Vector<>();
        for(int ii=0;ii<values.size();ii++){
            switch (properVector.function_arguments.get(funcName).get(ii)) {
                case "int" -> objects.add(Integer.valueOf(values.get(ii)));
                case "Date" -> {
                    SimpleDateFormat formatter = new SimpleDateFormat("dd-MMM-yyyy", Locale.ENGLISH);
                    try {
                        objects.add(formatter.parse(values.get(ii)));
                    } catch (ParseException e) {
                        e.printStackTrace();
                    }
                }
                case "float" -> objects.add(Float.valueOf(values.get(ii)));
                default -> objects.add(values.get(ii));
            }
        }
        return objects;
    }
}
