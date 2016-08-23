using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.Linq.SqlClient;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ModuleAsigAdminService" in both code and config file together.
    public class ModuleAsigAdminService : IModuleAsigAdminService
    {
        public int GetPensumID(int ProgramID, int ModuleID)
        {
            throw new NotImplementedException();
        }

        public void InsertAsignation(Pensum entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.Pensum.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void UpdateAsignation(int PensumID)
        {
            throw new NotImplementedException();
        }
    }
}
