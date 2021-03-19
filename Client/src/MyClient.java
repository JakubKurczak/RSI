public class MyClient {
    static final String url_name = "//localhost/MyService";

    public static void main(String[] args){
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
        }
        if(wynik != 0)
        System.out.println("Wynik" + wynik);
    }
}
