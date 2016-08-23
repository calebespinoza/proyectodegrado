using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicsServicesDIPP;
using QualificationsWebSystem.TeacherModuleService;
using QualificationsWebSystem.ModuleService;
using QualificationsWebSystem.ProgramService;
using QualificationsWebSystem.OpeningService;
using QualificationsWebSystem.GlobalPlanService;
using QualificationsWebSystem.EvaluationPlanService;
using QualificationsWebSystem.StudentModuleService;
using QualificationsWebSystem.QualificationService;

namespace QualificationsWebSystem
{
    public partial class Planilla_General : System.Web.UI.Page
    {
        string modulo = string.Empty;
        string gestion = string.Empty;
        string docente = string.Empty;

        string nombreModulo = string.Empty;
        string nombrePrograma = string.Empty;
        string version = string.Empty;
        //long globalPlanId = 0;

        TeacherModuleAdminServiceClient proxyTM = null;
        ModuleAdminServiceClient proxyModule = null;
        OpeningProgramAdminServiceClient proxyOP = null;
        GlobalPlanAdminServiceClient proxyGP = null;
        AcademicServiceClient proxyProgram = null;
        EvaluationPlanAdminServiceClient proxyEP = null;
        StudentModuleAdminServiceClient proxySM = null;
        QualificationAdminServiceClient proxyQ = null;


        Qualifications entity = null;
        Totals entityTotal = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxyTM = new TeacherModuleAdminServiceClient("WSHttpBinding_ITeacherModuleAdminService");
            proxyModule = new ModuleAdminServiceClient("WSHttpBinding_IModuleAdminService");
            proxyOP = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            proxyGP = new GlobalPlanAdminServiceClient("WSHttpBinding_IGlobalPlanAdminService");
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
            proxyEP = new EvaluationPlanAdminServiceClient("WSHttpBinding_IEvaluationPlanAdminService");
            proxySM = new StudentModuleAdminServiceClient("WSHttpBinding_IStudentModuleAdminService");
            proxyQ = new QualificationAdminServiceClient("WSHttpBinding_IQualificationAdminService");

            nombreModulo = Request.Params["ModuleName"].ToString();
            nombrePrograma = Request.Params["ProgramName"].ToString();
            version = Request.Params["ID"].ToString();
            //lbl_nameModulo.Text = "MODULO: " + nombreModulo;

            long programaId = proxyProgram.GetProgramID(nombrePrograma);
            int versionId = GetVersion(version);
            long aperturaId = proxyOP.GetOpeningID(programaId, versionId);
            long moduleId = proxyModule.GetModuleID(nombreModulo);
            long teachModuleId = proxyTM.GetTeacherModule(moduleId, aperturaId);
            Session["TeachModID"] = teachModuleId;
            long globalPlanId = proxyGP.GetGlobalPlan(teachModuleId);
            long evaluationPlanId = proxyEP.GetEvaluationPlanID(globalPlanId);
            Session["Evaluacion"] = evaluationPlanId;
            Session["GlobalPlanID"] = globalPlanId;

            ListaEstudiantesModulo(moduleId, versionId);
        }

        public void ListaEstudiante()
        {

        }

        public void ListaEstudiantesModulo(long ModuloId, long versionId)
        {
            using (var context = new QualificationsDBEntities())
            {
                var reporte = from sm in context.StudentModule
                              join p in context.Person
                              on sm.Student equals p.PersonId
                              join tm in context.TeachingModule
                              on sm.TeachingModuleCode equals tm.TeachingModuleCode
                              join op in context.OpeningProgram
                              on tm.OpeningCode equals op.OpeningCode
                              join m in context.Module
                              on tm.ModuleCode equals m.ModuleCode
                              join gp in context.GraduateProgram
                              on op.ProgramId equals gp.GraduateProgramaId
                              join v in context.Version
                              on op.Version equals v.ID
                              join q in context.Qualifications
                              on sm.StudentModuleCode equals q.StudentModuleCode
                              where m.ModuleCode == ModuloId && op.Version == versionId
                              orderby p.Name.Substring(0, 1) ascending
                              select new
                              {
                                  Código = p.PersonId,
                                  Nombre = p.Name + " " + p.FirstName + " " + p.LastName,
                                  Calificación = q.Qualification,
                                  
                              };
                GridView1.DataSource = reporte;
                GridView1.DataBind();
            }
        }

        public int GetVersion(string description)
        {
            int ID = 0;
            using (var context = new QualificationsDBEntities())
            {
                var version = from v in context.Version
                              where v.ProgramVersion == description
                              select v;
                foreach (var query in version)
                {
                    ID = query.ID;
                }
            }
            return ID;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}