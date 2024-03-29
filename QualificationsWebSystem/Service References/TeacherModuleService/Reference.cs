﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QualificationsWebSystem.TeacherModuleService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TeacherModuleService.ITeacherModuleAdminService")]
    public interface ITeacherModuleAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherModuleAdminService/InsertTeacherModule", ReplyAction="http://tempuri.org/ITeacherModuleAdminService/InsertTeacherModuleResponse")]
        void InsertTeacherModule(AcademicsServicesDIPP.TeachingModule entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherModuleAdminService/GetTeacherModule", ReplyAction="http://tempuri.org/ITeacherModuleAdminService/GetTeacherModuleResponse")]
        long GetTeacherModule(long moduloId, long openingId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITeacherModuleAdminServiceChannel : QualificationsWebSystem.TeacherModuleService.ITeacherModuleAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TeacherModuleAdminServiceClient : System.ServiceModel.ClientBase<QualificationsWebSystem.TeacherModuleService.ITeacherModuleAdminService>, QualificationsWebSystem.TeacherModuleService.ITeacherModuleAdminService {
        
        public TeacherModuleAdminServiceClient() {
        }
        
        public TeacherModuleAdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TeacherModuleAdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TeacherModuleAdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TeacherModuleAdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertTeacherModule(AcademicsServicesDIPP.TeachingModule entity) {
            base.Channel.InsertTeacherModule(entity);
        }
        
        public long GetTeacherModule(long moduloId, long openingId) {
            return base.Channel.GetTeacherModule(moduloId, openingId);
        }
    }
}
