using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IModuleAsigAdminService" in both code and config file together.
    [ServiceContract]
    public interface IModuleAsigAdminService
    {
        [OperationContract]
        int GetPensumID(int ProgramID, int ModuleID);

        [OperationContract]
        void InsertAsignation(Pensum entity);

        [OperationContract]
        void UpdateAsignation(int PensumID);
    }
}
