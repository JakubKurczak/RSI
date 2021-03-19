import java.rmi.Remote;
import java.rmi.RemoteException;

public interface CalcObject2 extends Remote {
    public ResultType2 calculate(Exercise inputType) throws RemoteException;
}
