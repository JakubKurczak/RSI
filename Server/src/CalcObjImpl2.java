import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

public class CalcObjImpl2 extends UnicastRemoteObject implements CalcObject2 {
    public CalcObjImpl2() throws RemoteException{
        super();
    }
    public ResultType2 calculate(Exercise inputType) throws RemoteException{
        ResultType2 result = new ResultType2();
        result.result = inputType.calculate();
        result.result_description = "success";
        return result;
    }
}
