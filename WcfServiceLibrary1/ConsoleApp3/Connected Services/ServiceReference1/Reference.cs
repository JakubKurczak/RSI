﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp3.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IKalkulator")]
    public interface IKalkulator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKalkulator/Dodaj", ReplyAction="http://tempuri.org/IKalkulator/DodajResponse")]
        double Dodaj(double val_1, double val_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKalkulator/Dodaj", ReplyAction="http://tempuri.org/IKalkulator/DodajResponse")]
        System.Threading.Tasks.Task<double> DodajAsync(double val_1, double val_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKalkulator/Odejmij", ReplyAction="http://tempuri.org/IKalkulator/OdejmijResponse")]
        double Odejmij(double val_1, double val_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKalkulator/Odejmij", ReplyAction="http://tempuri.org/IKalkulator/OdejmijResponse")]
        System.Threading.Tasks.Task<double> OdejmijAsync(double val_1, double val_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKalkulator/Pomnoz", ReplyAction="http://tempuri.org/IKalkulator/PomnozResponse")]
        double Pomnoz(double val_1, double val_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKalkulator/Pomnoz", ReplyAction="http://tempuri.org/IKalkulator/PomnozResponse")]
        System.Threading.Tasks.Task<double> PomnozAsync(double val_1, double val_2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKalkulator/Sumuj", ReplyAction="http://tempuri.org/IKalkulator/SumujResponse")]
        double Sumuj(double val_1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKalkulator/Sumuj", ReplyAction="http://tempuri.org/IKalkulator/SumujResponse")]
        System.Threading.Tasks.Task<double> SumujAsync(double val_1);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKalkulatorChannel : ConsoleApp3.ServiceReference1.IKalkulator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KalkulatorClient : System.ServiceModel.ClientBase<ConsoleApp3.ServiceReference1.IKalkulator>, ConsoleApp3.ServiceReference1.IKalkulator {
        
        public KalkulatorClient() {
        }
        
        public KalkulatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KalkulatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KalkulatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KalkulatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Dodaj(double val_1, double val_2) {
            return base.Channel.Dodaj(val_1, val_2);
        }
        
        public System.Threading.Tasks.Task<double> DodajAsync(double val_1, double val_2) {
            return base.Channel.DodajAsync(val_1, val_2);
        }
        
        public double Odejmij(double val_1, double val_2) {
            return base.Channel.Odejmij(val_1, val_2);
        }
        
        public System.Threading.Tasks.Task<double> OdejmijAsync(double val_1, double val_2) {
            return base.Channel.OdejmijAsync(val_1, val_2);
        }
        
        public double Pomnoz(double val_1, double val_2) {
            return base.Channel.Pomnoz(val_1, val_2);
        }
        
        public System.Threading.Tasks.Task<double> PomnozAsync(double val_1, double val_2) {
            return base.Channel.PomnozAsync(val_1, val_2);
        }
        
        public double Sumuj(double val_1) {
            return base.Channel.Sumuj(val_1);
        }
        
        public System.Threading.Tasks.Task<double> SumujAsync(double val_1) {
            return base.Channel.SumujAsync(val_1);
        }
    }
}
