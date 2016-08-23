using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdminOpeningProgramService" in both code and config file together.
    public class OpeningProgramAdminService : IOpeningProgramAdminService
    {
        long ID = 0;
        public void InsertOpening(OpeningProgram entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.OpeningProgram.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }


        public long GetOpeningID(long ProgramID, int version)
        {
            using (var context = new QualificationsDBEntities())
            {
                var opening = from o in context.OpeningProgram
                              where o.ProgramId == ProgramID & o.Version == version & o.Status == 1
                              select o;
                foreach (var query in opening)
                {
                    ID = query.OpeningCode;
                }
            }
            return ID;
        }
    }
}
