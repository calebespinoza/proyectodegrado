using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdminOpeningProgramService" in both code and config file together.
    [ServiceContract]
    public interface IOpeningProgramAdminService
    {
        [OperationContract]
        void InsertOpening(OpeningProgram entity);

        [OperationContract]
        long GetOpeningID(long ProgramID, int version);
    }
}
