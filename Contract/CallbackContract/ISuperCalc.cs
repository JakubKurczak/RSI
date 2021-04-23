using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CallbackContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract =typeof(ISuperCalcCallback))]
    public interface ISuperCalc
    {
        [OperationContract(IsOneWay =true)]
        void Factorial(double n);

        [OperationContract(IsOneWay = true)]
        void DoSomething(int sec);

    }
    interface ISuperCalcCallback
    {
        [OperationContract(IsOneWay = true)]
        void factorialResult(double res);

        [OperationContract(IsOneWay = true)]
        void doSomethingResult(string res);
    }
}
