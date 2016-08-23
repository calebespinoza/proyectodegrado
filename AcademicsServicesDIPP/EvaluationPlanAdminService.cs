using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EvaluationPlanAdminService" in both code and config file together.
    public class EvaluationPlanAdminService : IEvaluationPlanAdminService
    {
        long id = 0;
        public void InsertEvaluationPlan(EvaluationPlan entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.EvaluationPlan.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void InsertEvaluationFinal(EndEvaluation entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.EndEvaluation.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public long GetEvaluationPlanID(long globalPlanID)
        {
            using (var contex = new QualificationsDBEntities())
            {
                var query = from ep in contex.EvaluationPlan
                            where ep.GlobalPlanCode == globalPlanID
                            select ep;
                foreach (var ID in query)
                {
                    id = ID.EvaluationCode;
                }
            }
            return id;
        }
    }
}
