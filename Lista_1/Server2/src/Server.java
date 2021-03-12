import org.apache.xmlrpc.WebServer;

import java.util.Calendar;
import java.util.Date;
import java.util.Random;

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
        return "#getNextDate\nDate, int => Date\nFunction returns date x days into future from given date\n"
                + "#summary\nint, int => int\nAdds arguments and returns result\n"
                +"#randomWord\n () => String\nReturns random word\n"
                +"#sleepFunc\n () => int\n returns HTTP value 200 after 10 seconds\n";
    }

    public Date getNextDate(Date date, int days){
        var calendar = Calendar.getInstance();
        calendar.setTime(date);
        calendar.add(Calendar.DAY_OF_MONTH, days);
        return calendar.getTime();
    }

    public int summary(int x, int y){
        return x+y;
    }

    public String randomWord(){
        String[] statements = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum".split(" ");
        Random r = new Random();
        return statements[r.nextInt(statements.length)];
    }
    public int sleepFunc(){
        try {
            Thread.sleep(10000);
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        return 200;
    }

}
