import org.apache.xmlrpc.AsyncCallback;

import java.net.URL;

public class AsyncShow implements AsyncCallback {
    @Override
    public void handleResult(Object o, URL url, String s) {
        System.out.println("Async function response\nFrom: "+url+"\n"+o);
    }

    @Override
    public void handleError(Exception e, URL url, String s) {

    }
}
