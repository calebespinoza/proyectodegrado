using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IModuleAdminService" in both code and config file together.
    [ServiceContract]
    public interface IModuleAdminService
    {
        [OperationContract]
        void InsertModule(Module entity);

        [OperationContract]
        void UpdateModule(Module entity);

        [OperationContract]
        long GetModuleID(string nameModule);

        [OperationContract]
        Module Get(long id);
    }
}
