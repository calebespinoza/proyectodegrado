using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IQualificationAdminService" in both code and config file together.
    [ServiceContract]
    public interface IQualificationAdminService
    {
        [OperationContract]
        void InsertQualification(Qualifications entity);

        [OperationContract]
        float GetQualificationId(long evalCode);

        [OperationContract]
        void InsertQualificationTotals(Totals entity);
    }
}
