﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleBierClient.EtikettenService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://vdab.be/etikettenservice", ConfigurationName="EtikettenService.IEtikettenService")]
    public interface IEtikettenService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://vdab.be/etikettenservice/IEtikettenService/VerwijderEtikettenOuderDan")]
        void VerwijderEtikettenOuderDan(System.DateTime datum);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://vdab.be/etikettenservice/IEtikettenService/VerwijderEtikettenOuderDan")]
        System.Threading.Tasks.Task VerwijderEtikettenOuderDanAsync(System.DateTime datum);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEtikettenServiceChannel : ConsoleBierClient.EtikettenService.IEtikettenService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EtikettenServiceClient : System.ServiceModel.ClientBase<ConsoleBierClient.EtikettenService.IEtikettenService>, ConsoleBierClient.EtikettenService.IEtikettenService {
        
        public EtikettenServiceClient() {
        }
        
        public EtikettenServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EtikettenServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EtikettenServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EtikettenServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void VerwijderEtikettenOuderDan(System.DateTime datum) {
            base.Channel.VerwijderEtikettenOuderDan(datum);
        }
        
        public System.Threading.Tasks.Task VerwijderEtikettenOuderDanAsync(System.DateTime datum) {
            return base.Channel.VerwijderEtikettenOuderDanAsync(datum);
        }
    }
}
