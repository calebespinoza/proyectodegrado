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
    public partial class RegistrarCalificación : System.Web.UI.Page
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
            lbl_nameModulo.Text = "MODULO: " + nombreModulo;

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

        public void ListaEstudiantesModulo(long ModuloId, int versionId)
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
                              where m.ModuleCode == ModuloId && op.Version == versionId
                              orderby p.Name.Substring(0, 1) ascending
                              select new
                              {
                                  Código = p.PersonId,
                                  Nombre = p.Name + " " +p.FirstName + " " + p.LastName,
                              };
                GridView1.DataSource = reporte;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_nombreEstudiante.Text = GridView1.SelectedRow.Cells[2].Text;
            ListaEvaluaciones((long)Session["GlobalPlanID"]);
            btn_RegistrarParciales.Visible = true;
            btn_RegistrarFinal.Visible = true;
        }

        protected void btn_RegistrarParciales_Click(object sender, EventArgs e)
        {
            Label5.Visible = true;
            ddl_Evaluacion.Visible = true;
            //Label6.Visible = true;
            lbl_Ponderacion.Visible = true;
            lbl_Ponderacion.Text = "Valor de la Calificación entre 10 a 100 puntos";
            Label7.Visible = true;
            TextBox1.Visible = true;
            btn_notaParcial.Visible = true;
            //btn_RegistrarFinal.Visible = false;
        }

        public void ListaEvaluaciones(long GolbalPlanId)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from pe in context.EvaluationPlan
                            where pe.GlobalPlanCode == GolbalPlanId
                            select new
                            {
                                ID = pe.EvaluationCode,
                                Evaluacion = pe.Description
                            };
                ddl_Evaluacion.DataSource = query;
                ddl_Evaluacion.DataTextField = "Evaluacion";
                ddl_Evaluacion.DataValueField = "ID";
                ddl_Evaluacion.DataBind();
            }
        }

        protected void btn_notaParcial_Click(object sender, EventArgs e)
        {
            EvaluationPlan evaluation = new EvaluationPlan();
            long personId = long.Parse(GridView1.SelectedRow.Cells[1].Text);
            long stuModId = proxySM.GetStudentModuleId((long)Session["TeachModID"], personId);
            long evalPlanId = long.Parse(ddl_Evaluacion.SelectedValue);
            float value = float.Parse(TextBox1.Text);
            entity = new Qualifications();
            evaluation = GetPlanEvaluacion(evalPlanId);
            //lbl_Ponderacion.Text = evaluation.Consideration+"";

            try
            {
                entity.Qualification = value;
                entity.StudentModuleCode = stuModId;
                entity.EvaluationPlanCode = evalPlanId;

                proxyQ.InsertQualification(entity);
                TextBox1.Text = "";
                lbl_mensaje.Text = "ÉXITO. La calificación se ha registrado.";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Text = "ERROR. La calificación NO se ha registrado.";
            }
        }

        public EvaluationPlan GetPlanEvaluacion(long planId)
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.EvaluationPlan.FirstOrDefault(x => x.EvaluationCode == planId);
            }
        }

        protected void ddl_Evaluacion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void btn_RegistrarFinal_Click(object sender, EventArgs e)
        {
            btn_notaParcial.Visible = false;
            ListaFinal((long)Session["GlobalPlanID"]);
            btn_notaFinal.Visible = true;
        }


        public void ListaFinal(long globalPlanID)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from pe in context.EndEvaluation
                            where pe.Code == globalPlanID
                            select new
                            {
                                ID = pe.Code,
                                Evaluacion = pe.Description
                            };
                ddl_Evaluacion.DataSource = query;
                ddl_Evaluacion.DataTextField = "Evaluacion";
                ddl_Evaluacion.DataValueField = "ID";
                ddl_Evaluacion.DataBind();
            }
        }

        protected void btn_notaFinal_Click(object sender, EventArgs e)
        {
            string notaFinal = TextBox1.Text;
            float value = float.Parse(notaFinal);
            Totales(value);
            
        }

        public double TotalParcial(long studentModuleId)
        {
            double resultado = 0;
            string dato = string.Empty;
            float valor = 0;
            double total = 0;
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.Qualifications
                            where q.StudentModuleCode == studentModuleId
                            select new
                            {
                                q.Qualification
                            };
                foreach (var res in query)
                {
                    dato = res.Qualification + "";
                    valor = float.Parse(dato);
                    resultado = resultado + (valor * 0.5);
                }
                total = resultado;
            }
            return total;
        }

        public void Totales(float end)
        {
            double total = 0;
            long personId = long.Parse(GridView1.SelectedRow.Cells[1].Text);
            long stuModId = proxySM.GetStudentModuleId((long)Session["TeachModID"], personId);
            double res = TotalParcial(stuModId);

            double notaFinal = end;

            total = (res*0.6) + (notaFinal*0.4);
            //lbl_mensaje.Text = "" + total;
            string v = total+"";
            long t = long.Parse(v);

            entityTotal = new Totals();

            entityTotal.Code = stuModId;
            entityTotal.TotalPartial = res;
            entityTotal.TotalFinal = notaFinal;
            entityTotal.Total = t;

            proxyQ.InsertQualificationTotals(entityTotal);

            lbl_mensaje.Text = "ÉXITO. La nota se ha registrado.";
        }
    }
}