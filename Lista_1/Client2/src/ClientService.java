import org.apache.xmlrpc.XmlRpcClient;

import java.util.*;

import java.util.List;

public class ClientService {
    static int PORT=1051;
    static String HOST="localhost";
    public static void main(String[] args){
        if(args.length < 2)
            System.out.println("Not enough arguments to make connection!");
        else
        try{
            ClientService.PORT = Integer.parseInt(args[0]);
            ClientService.HOST = args[1];
            XmlRpcClient client = new XmlRpcClient("http://"+ClientService.HOST+":"+ClientService.PORT);
            Vector<Integer> params = new Vector<>();

            Object result = client.execute("MojSerwer.show", params);
            System.out.println("Available functionality:\n"+ result);



        }catch(Exception e){
            System.err.println(e);
        }
    }
}
