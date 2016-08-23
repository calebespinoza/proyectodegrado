﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEvaluationPlanAdminService" in both code and config file together.
    [ServiceContract]
    public interface IEvaluationPlanAdminService
    {
        [OperationContract]
        void InsertEvaluationPlan(EvaluationPlan entity);

        [OperationContract]
        void InsertEvaluationFinal(EndEvaluation entity);

        [OperationContract]
        long GetEvaluationPlanID(long globalPlanID);
    }
}
