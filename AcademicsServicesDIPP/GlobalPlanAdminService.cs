using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "GlobalPlanAdminService" in both code and config file together.
    public class GlobalPlanAdminService : IGlobalPlanAdminService
    {

        public void InsertGlobalPlan(GlobalPlan entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.GlobalPlan.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void InsertObjectives(ObjectivesSpecifics entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.ObjectivesSpecifics.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void InsertThematicContent(ContentThematic entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.ContentThematic.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void InsertLearningMethods(LearningMethods entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.LearningMethods.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void InsertTeachingMethods(TeachingMethods entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.TeachingMethods.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void InsertEvaluationsForms(EvaluationForms entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.EvaluationForms.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void InsertBibliography(Bibliography entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.Bibliography.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public long GetGlobalPlan(long TeachingModuleId)
        {
            long id = 0;
            using (var contex = new QualificationsDBEntities())
            {
                var query = from g in contex.GlobalPlan
                            where g.TeachingModuleCode == TeachingModuleId
                            select g;
                foreach (var ID in query)
                {
                    id = ID.GlobalPlanCode;
                }
            }
            return id;
        }

        public void UpdateGlobalPlan(GraduateProgram entity)
        {
            throw new NotImplementedException();
        }


        public void InsertStatusThematicContent(StatusThemeContent status)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.StatusThemeContent.Attach(status);
                context.ObjectStateManager.ChangeObjectState(status, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }
    }
}
