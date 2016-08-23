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

namespace QualificationsWebSystem
{
    public partial class RegistrarPlanEvaluaciones : System.Web.UI.Page
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

        EvaluationPlan entityEP = null;
        EndEvaluation entityEE = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxyTM = new TeacherModuleAdminServiceClient("WSHttpBinding_ITeacherModuleAdminService");
            proxyModule = new ModuleAdminServiceClient("WSHttpBinding_IModuleAdminService");
            proxyOP = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            proxyGP = new GlobalPlanAdminServiceClient("WSHttpBinding_IGlobalPlanAdminService");
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
            proxyEP = new EvaluationPlanAdminServiceClient("WSHttpBinding_IEvaluationPlanAdminService");

            nombreModulo = Request.Params["ModuleName"].ToString();
            nombrePrograma = Request.Params["ProgramName"].ToString();
            version = Request.Params["ID"].ToString();

            long programaId = proxyProgram.GetProgramID(nombrePrograma);
            int versionId = GetVersion(version);
            long aperturaId = proxyOP.GetOpeningID(programaId, versionId);
            long moduleId = proxyModule.GetModuleID(nombreModulo);
            long teachModuleId = proxyTM.GetTeacherModule(moduleId, aperturaId);
            long globalPlanId = proxyGP.GetGlobalPlan(teachModuleId);
            Session["GlobalPlanID"] = globalPlanId;
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

        public void ListaFormasEvaluacion(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.EvaluationForms
                            where q.GlobalPlan == id
                            select new
                            {
                                q.EvaluationForm
                            };
                foreach (var ev in query)
                {
                    ddl_formaEvaluacion.Items.Add(ev.EvaluationForm);
                }
            }
        }
        public void ComponentesGraficos1(bool value)
        {
            Label4.Visible = value;
            ddl_formaEvaluacion.Visible = value;
            Label5.Visible = value;
            ddl_Modalidad.Visible = value;
            Label6.Visible = value;
            txt_Description.Visible = value;
            Label7.Visible = value;
            Label8.Visible = value;
            Label9.Visible = value;
            Calendar1.Visible = value;
            btn_RegistrarParcial.Visible = value;
            txt_Ponderación.Visible = value;
            
        }

        public void ComponentesGráficos2(bool value)
        {
            btn_Parciales.Visible = value;
            btn_Final.Visible = value;
        }

        public void ComponentesGráficos3(bool value)
        {
            LinkButton1.Visible = value;
            LinkButton2.Visible = value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListaFormasEvaluacion((long)Session["GlobalPlanID"]);

            ComponentesGraficos1(true);
            ComponentesGráficos2(false);
            lbl_titulo.Text = "Las evaluaciones parciales representan el 60% de la calificación Total.";
            LinkButton2.Visible = true;
            //txt_Ponderación.Visible = true;
        }

        protected void btn_RegistrarParcial_Click(object sender, EventArgs e)
        {
            ComponentesGráficos3(true);
            ComponentesGraficos1(false);

            string forma = ddl_formaEvaluacion.SelectedValue;
            string modo = ddl_Modalidad.SelectedValue;
            string descripcion = txt_Description.Text;
            float ponderacion = float.Parse(txt_Ponderación.Text);
            DateTime fecha = Calendar1.SelectedDate;

            try
            {
                entityEP = new EvaluationPlan();

                entityEP.Form = forma;
                entityEP.Mode = modo;
                entityEP.Description = descripcion;
                entityEP.Consideration = ponderacion;
                entityEP.Date = fecha;
                entityEP.GlobalPlanCode = (long)Session["GlobalPlanID"];

                proxyEP.InsertEvaluationPlan(entityEP);
                lbl_Mensaje.Text = "ÉXITO. Los datos han sido Registrados.";
                ListaParciales((long)Session["GlobalPlanID"]);
                txt_Description.Text = "";
                txt_Ponderación.Text = "";
                Label10.Visible = true;
            }
            catch (Exception ex)
            {
                lbl_Mensaje.Text = "ERROR. Los datos NO han sido Registrados.";
            }
        }

        public void ListaParciales(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from pe in context.EvaluationPlan
                            where pe.GlobalPlanCode == id
                            select new
                            {
                                FormaEvaluación = pe.Form,
                                Modalidad = pe.Mode,
                                Ponderación = pe.Consideration,
                                Fecha = pe.Date,
                                Descripción = pe.Description
                            };
                GridView1.DataSource = query;
                GridView1.DataBind();
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            ComponentesGraficos1(true);
            ComponentesGráficos3(false);
            LinkButton2.Visible = true;
            lbl_Mensaje.Text = "";
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            ComponentesGraficos1(false);
            ComponentesGráficos2(true);
            ComponentesGráficos3(false);
            lbl_Mensaje.Text = "";
        }

        protected void btn_Final_Click(object sender, EventArgs e)
        {
            lbl_titulo.Text = "La evaluación final representa el 40 % de la calificación Total.";
            ComponentesGraficos1(true);

            txt_Ponderación.Visible = false;
            lbl_Ponderacion.Visible = true;
            lbl_Ponderacion.Text = "40%";
            Label9.Visible = false;
            LinkButton3.Visible = false;
            btn_Parciales.Visible = false;
            btn_Final.Visible = false;
            btn_EvaluacionFinal.Visible = true;
            btn_RegistrarParcial.Visible = false;
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("MenuDocente.aspx");
        }

        protected void btn_EvaluacionFinal_Click(object sender, EventArgs e)
        {
            lbl_Mensaje.Text = "Registrado";
            btn_EvaluacionFinal.Visible = false;
            LinkButton3.Visible = true;

            string forma = ddl_formaEvaluacion.SelectedValue;
            string modo = ddl_Modalidad.SelectedValue;
            string descripcion = txt_Description.Text;
            DateTime fecha = Calendar1.SelectedDate;

            try
            {
                entityEE = new EndEvaluation();

                entityEE.Form = forma;
                entityEE.Mode = modo;
                entityEE.Description = descripcion;
                entityEE.Consideration = 40;
                entityEE.Date = fecha;
                entityEE.Code = (long)Session["GlobalPlanID"];

                proxyEP.InsertEvaluationFinal(entityEE);
                lbl_Mensaje.Text = "ÉXITO. Los datos han sido Registrados.";
                ListaFinal((long)Session["GlobalPlanID"]);
                txt_Description.Text = "";
                txt_Ponderación.Text = "";
                Label11.Visible = true;
                
            }
            catch (Exception ex)
            {
                lbl_Mensaje.Text = "ERROR. Los datos NO han sido Registrados.";
                btn_EvaluacionFinal.Visible = true;
                LinkButton3.Visible = false;
            }
        }

        public void ListaFinal(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from pf in context.EndEvaluation
                            where pf.Code == id
                            select new
                            {
                                FormaEvaluación = pf.Form,
                                Modalidad = pf.Mode,
                                Ponderación = pf.Consideration,
                                Fecha = pf.Date,
                                Descripción = pf.Description
                            };
                GridView2.DataSource = query;
                GridView2.DataBind();
            }
        }
    }
}