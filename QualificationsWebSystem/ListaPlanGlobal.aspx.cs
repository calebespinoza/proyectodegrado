using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using AcademicsServicesDIPP;
using QualificationsWebSystem.TeacherModuleService;
using QualificationsWebSystem.ModuleService;
using QualificationsWebSystem.ProgramService;
using QualificationsWebSystem.OpeningService;
using QualificationsWebSystem.GlobalPlanService;

namespace QualificationsWebSystem
{
    public partial class Lista_Plan_Global : System.Web.UI.Page
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

        protected void Page_Load(object sender, EventArgs e)
        {
            proxyTM = new TeacherModuleAdminServiceClient("WSHttpBinding_ITeacherModuleAdminService");
            proxyModule = new ModuleAdminServiceClient("WSHttpBinding_IModuleAdminService");
            proxyOP = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            proxyGP = new GlobalPlanAdminServiceClient("WSHttpBinding_IGlobalPlanAdminService");
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");

            nombreModulo = Request.Params["ModuleName"].ToString();
            nombrePrograma = Request.Params["ProgramName"].ToString();
            version = Request.Params["ID"].ToString();

            long programaId = proxyProgram.GetProgramID(nombrePrograma);
            int versionId = GetVersion(version);
            long aperturaId = proxyOP.GetOpeningID(programaId, versionId);
            long moduleId = proxyModule.GetModuleID(nombreModulo);
            long teachModuleId = proxyTM.GetTeacherModule(moduleId, aperturaId);
            long globalPlanId = proxyGP.GetGlobalPlan(teachModuleId);

            Identificacion();
            Fundamentacion(globalPlanId);
            ObjetivoGeneral(globalPlanId);
            ObjetivoEspecifico(globalPlanId);
            ContenidoTematico(globalPlanId);
            MetodosEnseñanza(globalPlanId);
            MetodosAprendizaje(globalPlanId);
            FormasEvaluacion(globalPlanId);
            Bibliografia(globalPlanId);
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

        public void Identificacion()
        {
            long userId = long.Parse((string)Session["UserID"]);
            int versionId = GetVersion(version);
            
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.GlobalPlan
                            join tm in context.TeachingModule
                            on q.TeachingModuleCode equals tm.TeachingModuleCode
                            join m in context.Module
                            on tm.ModuleCode equals m.ModuleCode
                            join ua in context.UserAccount
                            on tm.Teacher equals ua.UserAccountId
                            join p in context.Person
                            on ua.UserAccountId equals p.PersonId
                            join op in context.OpeningProgram
                            on tm.OpeningCode equals op.OpeningCode
                            where ua.UserAccountId == userId && m.ModuleName == nombreModulo && op.Version == versionId
                            select new
                            {
                                modulo = m.ModuleName,
                                gestion = op.Gestion,
                                periodos = tm.Periods,
                                docente = p.Name+" "+p.FirstName+" "+p.LastName,
                                fecha = q.Fecha
                            };
                foreach (var s in query)
                {

                    lbl_Módulo.Text = "MÓDULO: " + s.modulo;
                    lbl_Gestion.Text = "GESTIÓN: " + s.gestion;
                    lbl_Periodos.Text = "CARGA HORARIA: " + s.periodos + " periodos";
                    lbl_Docente.Text = "DOCENTE: " + s.docente;
                    lbl_fecha.Text = "FECHA DE REGISTRO: " + s.fecha;
                }
            }
        }

        public void Fundamentacion(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.GlobalPlan
                            where q.GlobalPlanCode == id
                            select new
                            {
                                Fundamentación = q.Foundamentation
                            };
                gv_Fundamentacion.DataSource = query;
                gv_Fundamentacion.DataBind();
            }
        }

        public void ObjetivoGeneral(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.GlobalPlan
                            where q.GlobalPlanCode == id
                            select new
                            {
                                ObjetivoGeneral = q.GeneralObjective
                            };
                gv_ObjetivoGral.DataSource = query;
                gv_ObjetivoGral.DataBind();
            }
        }

        public void ObjetivoEspecifico(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.GlobalPlan
                            join oe in context.ObjectivesSpecifics
                            on q.GlobalPlanCode equals oe.GlobalPlan
                            where q.GlobalPlanCode == id
                            select new
                            {
                                Nro = oe.Number,
                                ObjetivosEspecíficos = oe.Description
                            };
                gv_ObjEspecificos.DataSource = query;
                gv_ObjEspecificos.DataBind();
            }
        }

        public void ContenidoTematico(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.GlobalPlan
                            join tc in context.ContentThematic
                            on q.GlobalPlanCode equals tc.GlobalPlan
                            join st in context.StatusThemeContent
                            on tc.Code equals st.ContentCode
                            join s in context.StatusTheme
                            on st.StatusThemeCode equals s.ID
                            where q.GlobalPlanCode == id
                            select new
                            {
                                Tema = tc.Theme,
                                ObjetivoInstrumental = tc.InstrumentalObjectives,
                                TemasInvetigación = tc.InvestigationThemes,
                                TrabajoPersonal = tc.PersonalWork,
                                TrabajoGrupal = tc.GroupWork,
                                EstadoAvance = s.Status
                            };
                gv_Contenido.DataSource = query;
                gv_Contenido.DataBind();
            }
        }

        public void MetodosEnseñanza(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.TeachingMethods
                            where q.PlanGlobal == id
                            select new
                            {
                                NombreMétodo = q.MethodName,
                                Descripción = q.Description,
                                Justificación = q.Justification
                            };
                gv_MetodosEnseñanza.DataSource = query;
                gv_MetodosEnseñanza.DataBind();
            }
        }

        public void MetodosAprendizaje(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.LearningMethods
                            where q.PlanGlobal == id
                            select new
                            {
                                NombreMétodo = q.MethodName,
                                Descripción = q.Description,
                                Justificación = q.Justification
                            };
                gv_MetodosAprendizaje.DataSource = query;
                gv_MetodosAprendizaje.DataBind();
            }
        }

        public void FormasEvaluacion(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.EvaluationForms
                            where q.GlobalPlan == id
                            select new
                            {
                                FormaEvaluación = q.EvaluationForm,
                                Descripción = q.Description,
                                Justificación = q.Justification
                            };
                gv_FormasEvaluacion.DataSource = query;
                gv_FormasEvaluacion.DataBind();
            }
        }

        public void Bibliografia(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.Bibliography
                            where q.GlobalPlan == id
                            select new
                            {
                                Título = q.Title,
                                Autor = q.Author,
                                Editorial = q.Editorial,
                                Año = q.Year
                            };
                gv_Bibliografia.DataSource = query;
                gv_Bibliografia.DataBind();
            }
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void gv_ObjEspecificos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}