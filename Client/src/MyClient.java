import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;

public class MyClient {
    static final String url_name = "//25.28.138.108:1098/MyService";
    static final String url_name_2 = "//25.28.138.108:1098/MyService";
    public static void main(String[] args){
        CalcObject2 calcObject2 = null;
        ResultType2 resultType = null;
        MyClient.hello();

        if(System.getSecurityManager() == null)
            System.setSecurityManager(new SecurityManager());

        try{
            calcObject2 = (CalcObject2) java.rmi.Naming.lookup(url_name_2);
        }catch (Exception e){
            System.out.println("Naming lookup fail");
            e.printStackTrace();
        }

        ArrayList<Exercise> polynomial = new ArrayList<>();
        polynomial.add(new Exercise(5,5,0));
        polynomial.add(new Exercise(4,2,1));
        polynomial.add(new Exercise(2,3,2));
        polynomial.add(new Exercise(2,4,3));
        polynomial.add(new Exercise(2,1,4));

        double result = 0;
        for(Exercise exe : polynomial){
            try{
                if(calcObject2 != null)
                    resultType = calcObject2.calculate(exe);
            }catch (Exception e){
                System.out.println("Remote call err");
                e.printStackTrace();
            }


            if(resultType != null){
                System.out.println( resultType.result_description +"\n" + "Wynik cząstkowy to  " + "\n" +resultType.result);
                result += resultType.result;
            }
        }
        System.out.println("Wynik wielomianu to: " + result);


    }

    static void hello(){
        //imie nazwisko nr albumu
        //data i czas do sekund
        //username
        System.out.println("Jakub Kurczak 237470");
        System.out.println("Maciej Rys 246648");
        System.out.println(LocalDateTime.now().format(DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss")));

        System.out.println(System.getProperty("user.name"));

    }
}
