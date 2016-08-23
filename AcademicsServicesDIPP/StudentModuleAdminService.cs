using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentModuleAdminService" in both code and config file together.
    public class StudentModuleAdminService : IStudentModuleAdminService
    {
        
        public void InsertStudentModule(StudentModule entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.StudentModule.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public long GetStudentModuleId(long teaching, long stydentId)
        {
            long id = 0;
            using (var contex = new QualificationsDBEntities())
            {
                var query = from m in contex.StudentModule
                            where m.TeachingModuleCode == teaching
                            select m;
                foreach (var ID in query)
                {
                    id = ID.StudentModuleCode;
                }
            }
            return id;
        }
    }
}
