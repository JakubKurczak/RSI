import org.apache.xmlrpc.WebServer;

public class Server {

    static int PORT=1051;
    public static void main(String[] args){
        try{
            System.out.println("Startuje server XML-RPC...");

            WebServer server = new WebServer(Server.PORT);
            server.addHandler("MojSerwer", new Server());
            server.start();
            System.out.println("Serwer uruchomiony pomyslnie na porcie "+Server.PORT);

        }catch(Exception e){
            System.err.println("Server XML-RPC: "+e);
        }
    }

    public String show(){
        return "Nothing for now";
    }
}
