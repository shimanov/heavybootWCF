﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.WCFService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WCFService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DataTable", ReplyAction="http://tempuri.org/IService/DataTableResponse")]
        string DataTable(string pcname, System.DateTime dateClient, System.DateTime exporTime, System.DateTime importTime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DataTable", ReplyAction="http://tempuri.org/IService/DataTableResponse")]
        System.Threading.Tasks.Task<string> DataTableAsync(string pcname, System.DateTime dateClient, System.DateTime exporTime, System.DateTime importTime);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : ClientApp.WCFService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<ClientApp.WCFService.IService>, ClientApp.WCFService.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DataTable(string pcname, System.DateTime dateClient, System.DateTime exporTime, System.DateTime importTime) {
            return base.Channel.DataTable(pcname, dateClient, exporTime, importTime);
        }
        
        public System.Threading.Tasks.Task<string> DataTableAsync(string pcname, System.DateTime dateClient, System.DateTime exporTime, System.DateTime importTime) {
            return base.Channel.DataTableAsync(pcname, dateClient, exporTime, importTime);
        }
    }
}