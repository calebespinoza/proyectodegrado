using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ModuleAdminService" in both code and config file together.
    public class ModuleAdminService : IModuleAdminService
    {

        long ModuleID = 0;
        public void InsertModule(Module entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.Module.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void UpdateModule(Module entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.Module.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
                context.SaveChanges();
            }
        }


        public long GetModuleID(string nameModule)
        {
            using (var contex = new QualificationsDBEntities())
            {
                var query = from m in contex.Module
                            where m.ModuleName == nameModule
                            select m;
                foreach (var ID in query)
                {
                    ModuleID = ID.ModuleCode;
                }
            }
            return ModuleID;
        }


        public Module Get(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.Module.FirstOrDefault(x => x.ModuleCode == id);
            }
        }
    }
}
