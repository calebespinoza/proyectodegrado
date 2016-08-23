using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IInscriptionAdminService" in both code and config file together.
    [ServiceContract]
    public interface IInscriptionAdminService
    {
        [OperationContract]
        void InsertProgram(GraduateProgram entity);

        [OperationContract]
        void UpdateProgram(GraduateProgram entity);
    }
}
