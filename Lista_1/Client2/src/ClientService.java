import org.apache.xmlrpc.XmlRpcClient;

import java.util.*;

import java.util.List;

public class ClientService {
    static int PORT=1051;
    static String HOST="localhost";
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        try{
            XmlRpcClient client = new XmlRpcClient("http://"+ClientService.HOST+":"+ClientService.PORT);
            Vector<Integer> params = new Vector<>();
            var call_bck = new AsyncShow();


            String command="";
            while(!command.equals("q")){
                Object response = client.execute("MojSerwer.show", params);
                properVector.setMap(response.toString());
                System.out.println(response);
                command = scanner.nextLine();
                try{
                    List<String> list_command = new LinkedList<>(Arrays.asList(command.split(" ")));
                    String function_name = list_command.get(0);
                    list_command.remove(0);

                    Object answer = client.execute("MojSerwer."+function_name, properVector.getProperVector(list_command,function_name));
                    System.out.println(answer);
                }catch(Exception e){
                    System.err.println(e);
                }
                System.out.println("Continue?[ENTER = YES, q = NO]");
                command = scanner.nextLine();
            }


        }catch(Exception e){
            System.err.println(e);
        }
    }
}
