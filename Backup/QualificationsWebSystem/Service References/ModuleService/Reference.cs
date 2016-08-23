﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QualificationsWebSystem.ModuleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ModuleService.IModuleAdminService")]
    public interface IModuleAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModuleAdminService/InsertModule", ReplyAction="http://tempuri.org/IModuleAdminService/InsertModuleResponse")]
        void InsertModule(AcademicsServicesDIPP.Module entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModuleAdminService/UpdateModule", ReplyAction="http://tempuri.org/IModuleAdminService/UpdateModuleResponse")]
        void UpdateModule(AcademicsServicesDIPP.Module entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModuleAdminService/GetModuleID", ReplyAction="http://tempuri.org/IModuleAdminService/GetModuleIDResponse")]
        long GetModuleID(string nameModule);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModuleAdminService/Get", ReplyAction="http://tempuri.org/IModuleAdminService/GetResponse")]
        AcademicsServicesDIPP.Module Get(long id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IModuleAdminServiceChannel : QualificationsWebSystem.ModuleService.IModuleAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ModuleAdminServiceClient : System.ServiceModel.ClientBase<QualificationsWebSystem.ModuleService.IModuleAdminService>, QualificationsWebSystem.ModuleService.IModuleAdminService {
        
        public ModuleAdminServiceClient() {
        }
        
        public ModuleAdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ModuleAdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ModuleAdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ModuleAdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertModule(AcademicsServicesDIPP.Module entity) {
            base.Channel.InsertModule(entity);
        }
        
        public void UpdateModule(AcademicsServicesDIPP.Module entity) {
            base.Channel.UpdateModule(entity);
        }
        
        public long GetModuleID(string nameModule) {
            return base.Channel.GetModuleID(nameModule);
        }
        
        public AcademicsServicesDIPP.Module Get(long id) {
            return base.Channel.Get(id);
        }
    }
}
