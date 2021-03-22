import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

public class MyServer{
//    static final String url_name="//localhost/MyService";
    static final String url_name_2 = "rmi://25.28.138.108:1098/MyService";

    public static void main(String[] args){

        System.setProperty("java.rmi.server.hostname", "25.28.138.108");
        if(System.getSecurityManager() == null)
            System.setSecurityManager(new SecurityManager());

        try{
            Registry registry = LocateRegistry.createRegistry(1098);
        }catch (Exception e){
            e.printStackTrace();
        }

        try{
            hello();
            CalcObjImpl2 impl = new CalcObjImpl2();
            java.rmi.Naming.rebind(url_name_2,impl);
            System.out.println("Server registered.");
            System.out.println("Press Ctrl + C to stop.");

        } catch (Exception e){
            System.out.println("Server cant be registered");
            e.printStackTrace();
        }
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