using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGlobalPlanAdminService" in both code and config file together.
    [ServiceContract]
    public interface IGlobalPlanAdminService
    {
        [OperationContract]
        void InsertGlobalPlan(GlobalPlan entity);

        [OperationContract]
        void InsertObjectives(ObjectivesSpecifics entity);

        [OperationContract]
        void InsertThematicContent(ContentThematic entity);

        [OperationContract]
        void InsertLearningMethods(LearningMethods entity);

        [OperationContract]
        void InsertTeachingMethods(TeachingMethods entity);

        [OperationContract]
        void InsertEvaluationsForms(EvaluationForms entity);

        [OperationContract]
        void InsertBibliography(Bibliography entity);

        [OperationContract]
        long GetGlobalPlan(long TeachingModuleId);

        [OperationContract]
        void InsertStatusThematicContent(StatusThemeContent status);

        [OperationContract]
        void UpdateGlobalPlan(GraduateProgram entity);
    }
}
