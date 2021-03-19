import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

public class CalcObjImpl2 extends UnicastRemoteObject implements CalcObject2 {
    public CalcObjImpl2() throws RemoteException{
        super();
    }
    public ResultType calculate(InputType inputType) throws RemoteException{
        double zm1,zm2;
        ResultType result = new ResultType();

        zm1 = inputType.getX1();
        zm2 = inputType.getX2();
        result.result_description = "Operation: "+inputType.operation;

        switch(inputType.operation){
            case "add":
                result.result = zm1 + zm2;
                break;
            case "sub":
                result.result = zm1 - zm2;
                break;
            default:
                result.result = 0;
                result.result_description = "There is no operation: "+inputType.operation;
                return result;
        }
        return result;
    }
}
