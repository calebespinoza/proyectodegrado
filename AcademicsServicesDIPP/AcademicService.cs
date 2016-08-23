using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.EntityModel;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.Linq.SqlClient;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AcademicService : IAcademicService
    {
        long nroUserRole = 0;
        long programID = 0;
        private List<Program> customers = null;
        private Program customer = null;

        #region IAcademicService Members

        public void InsertProgram(GraduateProgram entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.GraduateProgram.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void UpdateProgram(GraduateProgram entity)
        {
            throw new NotImplementedException();
        }

        public List<Program> GetAll()
        {
            customers = new List<Program>();
            using (var context = new QualificationsDBEntities())
            {
                //return context.GraduateProgram.OrderBy(x => x.GraduateProgramaId).ToList();
                var query = from gp in context.GraduateProgram select gp;
                foreach (var p in query)
                {
                    customer.ProgramName = p.ProgramName;
                    customers.Add(customer);
                }
            }
            return customers;
        }
        #endregion


        public long GetProgramID(string nameProgram)
        {
            using (var contex = new QualificationsDBEntities())
            {
                var query = from p in contex.GraduateProgram
                            where p.ProgramName == nameProgram
                            select p;
                foreach (var ID in query)
                {
                    programID = ID.GraduateProgramaId;
                }
            }
            return programID;
        }
    }
}
