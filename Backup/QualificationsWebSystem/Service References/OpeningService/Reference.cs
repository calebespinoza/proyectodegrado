﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QualificationsWebSystem.OpeningService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OpeningService.IOpeningProgramAdminService")]
    public interface IOpeningProgramAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOpeningProgramAdminService/InsertOpening", ReplyAction="http://tempuri.org/IOpeningProgramAdminService/InsertOpeningResponse")]
        void InsertOpening(AcademicsServicesDIPP.OpeningProgram entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOpeningProgramAdminService/GetOpeningID", ReplyAction="http://tempuri.org/IOpeningProgramAdminService/GetOpeningIDResponse")]
        long GetOpeningID(long ProgramID, int version);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOpeningProgramAdminServiceChannel : QualificationsWebSystem.OpeningService.IOpeningProgramAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OpeningProgramAdminServiceClient : System.ServiceModel.ClientBase<QualificationsWebSystem.OpeningService.IOpeningProgramAdminService>, QualificationsWebSystem.OpeningService.IOpeningProgramAdminService {
        
        public OpeningProgramAdminServiceClient() {
        }
        
        public OpeningProgramAdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OpeningProgramAdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OpeningProgramAdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OpeningProgramAdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertOpening(AcademicsServicesDIPP.OpeningProgram entity) {
            base.Channel.InsertOpening(entity);
        }
        
        public long GetOpeningID(long ProgramID, int version) {
            return base.Channel.GetOpeningID(ProgramID, version);
        }
    }
}
