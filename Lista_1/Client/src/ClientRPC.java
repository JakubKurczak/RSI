import org.apache.xmlrpc.XmlRpcClient;

import java.util.Vector;

public class ClientRPC {
    static int PORT=1051;
    static String HOST="localhost";
    public static void main(String[] args){
        try{
            XmlRpcClient client = new XmlRpcClient("http://"+ClientRPC.HOST+":"+ClientRPC.PORT);
            Vector<Integer> params = new Vector<>();
            params.addElement(13);
            params.addElement(21);
            Object result = client.execute("MojSerwer.echo",params);
            System.out.println("Otrzymany wynik to: "+ result);

            AC a_callback = new AC();

            Vector<Integer> params_2 = new Vector<>();
            params_2.addElement(30);
            client.executeAsync("MojSerwer.execAsync",params_2,a_callback);

        }catch(Exception e){
            System.err.println(e);
        }
    }
}
