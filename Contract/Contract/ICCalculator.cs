using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Contract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICCalculator
    {
        [OperationContract]
        ComplexNum addCNum(ComplexNum n1, ComplexNum n2);

        // TODO: Add your service operations here
    }

    [ServiceContract]
    public interface IAsyncService
    {
        [OperationContract(IsOneWay = true)]
        void Fun1(String s);

        [OperationContract]
        void Fun2(String s);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Contract.ContractType".
    [DataContract]
    public class ComplexNum
    {
        string desciption = "Complex number";

        [DataMember]
        public double real;

        [DataMember]
        public double imag;

        [DataMember]
        public string Desc
        {
            get { return desciption; }
            set { desciption = value; }
        }

        public ComplexNum(double r, double i)
        {
            this.real = r;
            this.imag = i;
        }
    }
}
