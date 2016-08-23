using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TeacherModuleAdminService" in both code and config file together.
    public class TeacherModuleAdminService : ITeacherModuleAdminService
    {

        public void InsertTeacherModule(TeachingModule entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.TeachingModule.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public long GetTeacherModule(long moduloId, long openingId)
        {
            long teachModId = 0;
            using (var context = new QualificationsDBEntities())
            {
                var teachmod = from tm in context.TeachingModule
                               where tm.ModuleCode == moduloId && tm.OpeningCode == openingId
                               select tm;
                foreach (var query in teachmod)
                {
                    teachModId = query.TeachingModuleCode;
                }
            }
            return teachModId;
        }
    }
}
