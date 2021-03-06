﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleBierClient.RadenService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RaadResultaat", Namespace="http://schemas.datacontract.org/2004/07/BierenServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class RaadResultaat : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BeurtenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleBierClient.RadenService.Hint HintField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Beurten {
            get {
                return this.BeurtenField;
            }
            set {
                if ((this.BeurtenField.Equals(value) != true)) {
                    this.BeurtenField = value;
                    this.RaisePropertyChanged("Beurten");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleBierClient.RadenService.Hint Hint {
            get {
                return this.HintField;
            }
            set {
                if ((this.HintField.Equals(value) != true)) {
                    this.HintField = value;
                    this.RaisePropertyChanged("Hint");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Hint", Namespace="http://schemas.datacontract.org/2004/07/BierenServiceLibrary")]
    public enum Hint : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Hoger = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Lager = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Correct = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://vdab.be/alcoholradenservice", ConfigurationName="RadenService.IRadenService")]
    public interface IRadenService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vdab.be/alcoholradenservice/IRadenService/RaadDuvelAlcohol", ReplyAction="http://vdab.be/alcoholradenservice/IRadenService/RaadDuvelAlcoholResponse")]
        ConsoleBierClient.RadenService.RaadResultaat RaadDuvelAlcohol(decimal Alcohol);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vdab.be/alcoholradenservice/IRadenService/RaadDuvelAlcohol", ReplyAction="http://vdab.be/alcoholradenservice/IRadenService/RaadDuvelAlcoholResponse")]
        System.Threading.Tasks.Task<ConsoleBierClient.RadenService.RaadResultaat> RaadDuvelAlcoholAsync(decimal Alcohol);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRadenServiceChannel : ConsoleBierClient.RadenService.IRadenService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RadenServiceClient : System.ServiceModel.ClientBase<ConsoleBierClient.RadenService.IRadenService>, ConsoleBierClient.RadenService.IRadenService {
        
        public RadenServiceClient() {
        }
        
        public RadenServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RadenServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RadenServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RadenServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsoleBierClient.RadenService.RaadResultaat RaadDuvelAlcohol(decimal Alcohol) {
            return base.Channel.RaadDuvelAlcohol(Alcohol);
        }
        
        public System.Threading.Tasks.Task<ConsoleBierClient.RadenService.RaadResultaat> RaadDuvelAlcoholAsync(decimal Alcohol) {
            return base.Channel.RaadDuvelAlcoholAsync(Alcohol);
        }
    }
}
