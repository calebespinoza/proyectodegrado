using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthenticationService" in both code and config file together.
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        long AuthenticateUser(string username, string password);

        [OperationContract]
        string GetRole(long value);

        [OperationContract]
        long GetID(string username, string password);

        [OperationContract]
        string GetPerson(long ID);
    }
}
