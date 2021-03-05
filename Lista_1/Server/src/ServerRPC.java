import org.apache.xmlrpc.WebServer;

public class ServerRPC {
    static int PORT=1051;
    public static void main(String[] args){
        try{
            System.out.println("Startuje server XML-RPC...");

            WebServer server = new WebServer(ServerRPC.PORT);
            server.addHandler("MojSerwer", new ServerRPC());
            server.start();
            System.out.println("Serwer uruchomiony pomyslnie na porcie "+ServerRPC.PORT);

        }catch(Exception e){
            System.err.println("Server XML-RPC: "+e);
        }
    }

    public Integer echo(int x, int y){

        System.out.println("Wywolano metode synchroniczna");
        return x + y;
    }

    public Integer execAsync(int x){
        System.out.println("Wywolano metode asynchroniczna - odliczam");
        try{
            Thread.sleep(x);
            System.out.println("Wywolano metode asynchroniczna - koniec odliczania");
        }catch (InterruptedException e){
            e.printStackTrace();
            Thread.currentThread().interrupt();
        }

        return (200);
    }
}

