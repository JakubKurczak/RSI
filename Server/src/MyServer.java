import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class MyServer{
    static final String url_name="//localhost/MyService";
    static final String url_name_2 = "//localhost/MyService2";

    public static void main(String[] args){


        if(System.getSecurityManager() == null)
            System.setSecurityManager(new SecurityManager());

        try{
            Registry registry = LocateRegistry.createRegistry(1098);
        }catch (Exception e){
            e.printStackTrace();
        }

        try{
            CalcObjImpl2 impl = new CalcObjImpl2();
            java.rmi.Naming.rebind(url_name_2,impl);
            System.out.println("Server registered.");
            System.out.println("Press Ctrl + C to stop.");

        } catch (Exception e){
            System.out.println("Server cant be registered");
            e.printStackTrace();
        }
    }
}