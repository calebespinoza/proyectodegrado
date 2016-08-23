using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QualificationsWebSystem.OpeningService;
using QualificationsWebSystem.ProgramService;
using QualificationsWebSystem.ModuleService;
using QualificationsWebSystem.TeacherModuleService;
using QualificationsWebSystem.StudentModuleService;
using QualificationsWebSystem.UserAccountAdminService;
using AcademicsServicesDIPP;

namespace QualificationsWebSystem
{
    public partial class EliminarInscripción : System.Web.UI.Page
    {
        string nombre = string.Empty;
        string paterno = string.Empty;
        string materno = string.Empty;
        string modulo = string.Empty;
        string programa = string.Empty;
        string version = string.Empty;
        string ci = string.Empty;

        AcademicServiceClient proxyProgram = null;
        OpeningProgramAdminServiceClient proxyOpening = null;
        ModuleAdminServiceClient proxyModule = null;
        TeacherModuleAdminServiceClient proxyTeachMod = null;
        StudentModuleAdminServiceClient proxyStuMod = null;

        StudentModule entity = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
            proxyOpening = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            proxyModule = new ModuleAdminServiceClient("WSHttpBinding_IModuleAdminService");
            proxyTeachMod = new TeacherModuleAdminServiceClient("WSHttpBinding_ITeacherModuleAdminService");
            proxyStuMod = new StudentModuleAdminServiceClient("WSHttpBinding_IStudentModuleAdminService");

            nombre = Request.Params[0].ToString();
            paterno = Request.Params[1].ToString();
            materno = Request.Params[2].ToString();
            modulo = Request.Params[3].ToString();
            programa = Request.Params[4].ToString();
            version = Request.Params[5].ToString();

            lbl_ProgramaPost.Text = "PROGRAMA DE POSTGRADO: " + programa;
            lbl_Version.Text = "VERSIÓN: "+version;
            lbl_Modulo.Text = "MÓDULO: "+modulo;
            lbl_Estudiante.Text = "ESTUDIANTE: "+nombre+" "+paterno+" "+materno;
        }

        public StudentModule GetStudentModule(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.StudentModule.FirstOrDefault(x => x.StudentModuleCode == id);
            }
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            long programID = proxyProgram.GetProgramID(programa);
            int versionID = VersionID(version);
            long openingID = proxyOpening.GetOpeningID(programID, versionID);
            long moduloID = proxyModule.GetModuleID(modulo);
            long personID = GetPerson(nombre, paterno, materno);
            long teamodID = proxyTeachMod.GetTeacherModule(moduloID, openingID);
            long studModuleID = proxyStuMod.GetStudentModuleId(teamodID, personID);

            try
            {
                entity = new StudentModule();
                entity = GetStudentModule(studModuleID);
                DeleteInscription(entity);
                lbl_Mensaje.Text = "ÉXITO. El registro de Inscripción ha sido eliminado de la Base de Datos";
               
            }
            catch (Exception ex)
            {
                lbl_Mensaje.Text = "ERROR. No se ha eliminado el registro de Inscripción";
            }



        }

        public void DeleteInscription(StudentModule entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.StudentModule.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Deleted);
                context.SaveChanges();
            }
        }

        public long GetPerson(string nombre, string aP, string aM)
        {
            long personID = 0;
            using (var context = new QualificationsDBEntities())
            {
                var person = from p in context.Person where p.Name == nombre & p.FirstName == aP & p.LastName == aM 
                             select p;
                foreach (var id in person)
                {
                    personID = id.PersonId;
                }
            }
            return personID;
        }

        public int VersionID(string version)
        {
            int versionID = 0;
            using (var context = new QualificationsDBEntities())
            {
                var id = from v in context.Version
                         where v.ProgramVersion == version
                         select new
                         {
                             version = v.ID
                         };

                foreach (var query in id)
                {
                    versionID = query.version;
                }
            }

            return versionID;
        }
    }
}