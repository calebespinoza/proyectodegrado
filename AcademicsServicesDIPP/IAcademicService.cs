using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAcademicService
    {   
        [OperationContract]
        void InsertProgram(GraduateProgram entity);

        [OperationContract]
        void UpdateProgram(GraduateProgram entity);

        [OperationContract]
        List<Program> GetAll();

        [OperationContract]
        long GetProgramID(string nameProgram);

    }

    [DataContract]
    public class Program
    {
        [DataMember]
        public string ProgramName { get; set; }
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations
}
