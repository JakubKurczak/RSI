using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class MojKalkulator : IKalkulator
    {
        double suma = 0;
        public double Dodaj(double val_1, double val_2)
        {
            return val_1 + val_2;
        }

       
        public double Odejmij(double val_1, double val_2)
        {
            return val_1 - val_2;
        }

        public double Pomnoz(double val_1, double val_2)
        {
            return val_1 * val_2;
        }

        public double Sumuj(double val_1)
        {
            this.suma += val_1;
            return suma;
        }
    }
}
