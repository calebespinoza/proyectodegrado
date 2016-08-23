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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuthenticationService" in both code and config file together.
    public class AuthenticationService : IAuthenticationService
    {
        long nroUserRole = 0;
        string roleName = string.Empty;
        long id = 0;

        public long AuthenticateUser(string username, string password)
        {
            using (var context = new QualificationsDBEntities())
            {
                var user = from u in context.UserAccount where u.Account == username & u.Password == password select u;
                foreach (var authenticate in user)
                {
                    if (username == authenticate.Account && password == authenticate.Password && authenticate.AccountStatus == 1)
                    {
                        var userRole = from ur in context.UserRole where ur.UserAccountId == authenticate.UserAccountId select ur;
                        foreach (var role in userRole)
                        {
                            nroUserRole = role.RoleCode;
                        }
                    }
                }
            }
            return nroUserRole;
        }

        public string GetRole(long value)
        {
            using (var context = new QualificationsDBEntities())
            {
                var role = from r in context.ListRole where r.RoleCode == value select r;
                foreach (var rn in role)
                {
                    roleName = rn.RoleName;
                }
            }
            return roleName;
        }

        public long GetID(string username, string password)
        {
            using (var context = new QualificationsDBEntities())
            {
                var user = from u in context.UserAccount where u.Account == username & u.Password == password select u;
                foreach (var authenticate in user)
                {
                    id = authenticate.UserAccountId;
                }
            }
            return id;
        }

        public string GetPerson(long ID)
        {
            string name = string.Empty;

            using (var context = new QualificationsDBEntities())
            {
                var person = from p in context.Person where p.PersonId == ID select p;
                foreach (var n in person)
                {
                    name = n.Name+" "+n.FirstName +" "+n.LastName;
                }
            }

            return name;
        }
    }
}
