public class MyClient {
    static final String url_name = "//localhost/MyService";
    static final String url_name_2 = "//localhost/MyService2";
    public static void main(String[] args){

        /*
        double wynik = 0;
        CalcObject zObiekt = null;
        if(System.getSecurityManager() == null)
            System.setSecurityManager(new SecurityManager());

        try{
            zObiekt = (CalcObject) java.rmi.Naming.lookup(url_name);
        }catch (Exception e){
            System.out.println("Naming lookup fail");
            e.printStackTrace();
        }


        try{
            if(zObiekt != null)
            wynik = zObiekt.calculate(1.1,2.2);
        }catch (Exception e){
            System.out.println("Remote call err");
            e.printStackTrace();
        }*/
        CalcObject2 calcObject2 = null;
        ResultType resultType = null;
        InputType inputType = new InputType();
        inputType.x1 = 2.0;
        inputType.x2 = 5.5;
        inputType.operation = "add";

        if(System.getSecurityManager() == null)
            System.setSecurityManager(new SecurityManager());

        try{
            calcObject2 = (CalcObject2) java.rmi.Naming.lookup(url_name_2);
        }catch (Exception e){
            System.out.println("Naming lookup fail");
            e.printStackTrace();
        }


        try{
            if(calcObject2 != null)
                resultType = calcObject2.calculate(inputType);
        }catch (Exception e){
            System.out.println("Remote call err");
            e.printStackTrace();
        }


        if(resultType != null)
        System.out.println("Wynik " + resultType.result_description +"\n"+resultType.result);
    }
}
