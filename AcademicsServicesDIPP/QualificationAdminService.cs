using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "QualificationAdminService" in both code and config file together.
    public class QualificationAdminService : IQualificationAdminService
    {

        public void InsertQualification(Qualifications entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.Qualifications.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public float GetQualificationId(long evalCode)
        {
            throw new NotImplementedException();
        }

        public void InsertQualificationTotals(Totals entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.Totals.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }
    }
}
