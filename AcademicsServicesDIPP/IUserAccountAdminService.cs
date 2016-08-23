using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IUserAccountAdminService
    {
        [OperationContract]
        void InsertPerson(Person person);

        [OperationContract]
        long GetPerson(long ci, string nombre,string aP, string aM);

        [OperationContract]
        void InsertUserAccount(UserAccount useraccount);

        [OperationContract]
        void InsertUserRole(UserRole userRole);

        [OperationContract]
        void UpdateUserAccount(UserAccount entity);

        [OperationContract]
        long GetUserID(string account, string pass);
    }
}
