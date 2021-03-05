import org.apache.xmlrpc.AsyncCallback;

import java.net.URL;

public class AC implements AsyncCallback {
    @Override
    public void handleResult(Object o, URL url, String s) {
        System.out.println("Async results: "+o);
    }

    @Override
    public void handleError(Exception e, URL url, String s) {
        System.err.println(e);
    }
}
