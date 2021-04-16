using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(ProtectionLevel =System.Net.Security.ProtectionLevel.None)]
    public interface IKalkulator
    {
        [OperationContract]
        double Dodaj(double val_1, double val_2);
        [OperationContract]
        double Odejmij(double val_1, double val_2);
        [OperationContract]
        double Pomnoz(double val_1, double val_2);

        // TODO: Add your service operations here
    }

}
