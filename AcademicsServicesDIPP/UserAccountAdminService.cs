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
using System.Data.SqlClient;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class UserAccountAdminService : IUserAccountAdminService
    {
        long personID = 0;

        public void InsertPerson(Person person)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.Person.Attach(person);
                context.ObjectStateManager.ChangeObjectState(person, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void InsertUserAccount(UserAccount useraccount)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.UserAccount.Attach(useraccount);
                context.ObjectStateManager.ChangeObjectState(useraccount, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }

        public void UpdateUserAccount(UserAccount entity)
        {
            throw new NotImplementedException();
        }


        public void InsertUserRole(UserRole userRole)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.UserRole.Attach(userRole);
                context.ObjectStateManager.ChangeObjectState(userRole, System.Data.EntityState.Added);
                context.SaveChanges();
            }
        }


        public long GetPerson(long ci, string nombre, string aP, string aM)
        {
            using (var context = new QualificationsDBEntities())
            {
                var person = from p in context.Person where p.Name == nombre & p.FirstName == aP & p.LastName == aM & p.IdentityCard == ci select p;
                foreach (var id in person)
                {
                    personID = id.PersonId;
                }
            }
            return personID;
        }


        public long GetUserID(string account, string pass)
        {
            long userID = 0;
            using (var context = new QualificationsDBEntities())
            {
                var user = from u in context.UserAccount where u.Account == account & u.Password == pass select u;
                foreach (var id in user)
                {
                    userID = id.UserAccountId;
                }
            }
            return userID;
        }
    }

}
