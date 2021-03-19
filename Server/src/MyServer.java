public class MyServer{
    static final String url_name="//localhost/MyService";

    public static void main(String[] args){
        if(System.getSecurityManager() == null)
            System.setSecurityManager(new SecurityManager());
        try{
            CalcObjImpl impl = new CalcObjImpl();
            java.rmi.Naming.rebind(url_name,impl);
            System.out.println("Server registered.");
            System.out.println("Press Ctrl + C to stop.");

        } catch (Exception e){
            System.out.println("Server cant be registered");
            e.printStackTrace();
            return;
        }
    }
}