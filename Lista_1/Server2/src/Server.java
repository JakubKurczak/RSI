import org.apache.xmlrpc.WebServer;

import java.util.Calendar;
import java.util.Date;

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
        return "#getNextDate\nDate, int => Date\nFunction returns date x days into future from given date\n";
    }

    public Date getNextDate(Date date, int days){
        var calendar = Calendar.getInstance();
        calendar.setTime(date);
        calendar.add(Calendar.DAY_OF_MONTH, days);
        return calendar.getTime();
    }
}
