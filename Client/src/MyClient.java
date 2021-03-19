import java.util.ArrayList;

public class MyClient {
    static final String url_name = "//localhost/MyService";
    static final String url_name_2 = "//localhost/MyService2";
    public static void main(String[] args){
        CalcObject2 calcObject2 = null;
        ResultType2 resultType = null;


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
}
