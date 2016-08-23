﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QualificationsWebSystem.GlobalPlanService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GlobalPlanService.IGlobalPlanAdminService")]
    public interface IGlobalPlanAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalPlanAdminService/InsertGlobalPlan", ReplyAction="http://tempuri.org/IGlobalPlanAdminService/InsertGlobalPlanResponse")]
        void InsertGlobalPlan(AcademicsServicesDIPP.GlobalPlan entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalPlanAdminService/InsertObjectives", ReplyAction="http://tempuri.org/IGlobalPlanAdminService/InsertObjectivesResponse")]
        void InsertObjectives(AcademicsServicesDIPP.ObjectivesSpecifics entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalPlanAdminService/InsertThematicContent", ReplyAction="http://tempuri.org/IGlobalPlanAdminService/InsertThematicContentResponse")]
        void InsertThematicContent(AcademicsServicesDIPP.ContentThematic entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalPlanAdminService/InsertLearningMethods", ReplyAction="http://tempuri.org/IGlobalPlanAdminService/InsertLearningMethodsResponse")]
        void InsertLearningMethods(AcademicsServicesDIPP.LearningMethods entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalPlanAdminService/InsertTeachingMethods", ReplyAction="http://tempuri.org/IGlobalPlanAdminService/InsertTeachingMethodsResponse")]
        void InsertTeachingMethods(AcademicsServicesDIPP.TeachingMethods entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalPlanAdminService/InsertEvaluationsForms", ReplyAction="http://tempuri.org/IGlobalPlanAdminService/InsertEvaluationsFormsResponse")]
        void InsertEvaluationsForms(AcademicsServicesDIPP.EvaluationForms entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalPlanAdminService/InsertBibliography", ReplyAction="http://tempuri.org/IGlobalPlanAdminService/InsertBibliographyResponse")]
        void InsertBibliography(AcademicsServicesDIPP.Bibliography entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalPlanAdminService/GetGlobalPlan", ReplyAction="http://tempuri.org/IGlobalPlanAdminService/GetGlobalPlanResponse")]
        long GetGlobalPlan(long TeachingModuleId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalPlanAdminService/InsertStatusThematicContent", ReplyAction="http://tempuri.org/IGlobalPlanAdminService/InsertStatusThematicContentResponse")]
        void InsertStatusThematicContent(AcademicsServicesDIPP.StatusThemeContent status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGlobalPlanAdminService/UpdateGlobalPlan", ReplyAction="http://tempuri.org/IGlobalPlanAdminService/UpdateGlobalPlanResponse")]
        void UpdateGlobalPlan(AcademicsServicesDIPP.GraduateProgram entity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGlobalPlanAdminServiceChannel : QualificationsWebSystem.GlobalPlanService.IGlobalPlanAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GlobalPlanAdminServiceClient : System.ServiceModel.ClientBase<QualificationsWebSystem.GlobalPlanService.IGlobalPlanAdminService>, QualificationsWebSystem.GlobalPlanService.IGlobalPlanAdminService {
        
        public GlobalPlanAdminServiceClient() {
        }
        
        public GlobalPlanAdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GlobalPlanAdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GlobalPlanAdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GlobalPlanAdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertGlobalPlan(AcademicsServicesDIPP.GlobalPlan entity) {
            base.Channel.InsertGlobalPlan(entity);
        }
        
        public void InsertObjectives(AcademicsServicesDIPP.ObjectivesSpecifics entity) {
            base.Channel.InsertObjectives(entity);
        }
        
        public void InsertThematicContent(AcademicsServicesDIPP.ContentThematic entity) {
            base.Channel.InsertThematicContent(entity);
        }
        
        public void InsertLearningMethods(AcademicsServicesDIPP.LearningMethods entity) {
            base.Channel.InsertLearningMethods(entity);
        }
        
        public void InsertTeachingMethods(AcademicsServicesDIPP.TeachingMethods entity) {
            base.Channel.InsertTeachingMethods(entity);
        }
        
        public void InsertEvaluationsForms(AcademicsServicesDIPP.EvaluationForms entity) {
            base.Channel.InsertEvaluationsForms(entity);
        }
        
        public void InsertBibliography(AcademicsServicesDIPP.Bibliography entity) {
            base.Channel.InsertBibliography(entity);
        }
        
        public long GetGlobalPlan(long TeachingModuleId) {
            return base.Channel.GetGlobalPlan(TeachingModuleId);
        }
        
        public void InsertStatusThematicContent(AcademicsServicesDIPP.StatusThemeContent status) {
            base.Channel.InsertStatusThematicContent(status);
        }
        
        public void UpdateGlobalPlan(AcademicsServicesDIPP.GraduateProgram entity) {
            base.Channel.UpdateGlobalPlan(entity);
        }
    }
}