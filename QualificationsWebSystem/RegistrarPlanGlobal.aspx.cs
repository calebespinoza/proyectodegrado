using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QualificationsWebSystem.GlobalPlanService;
using QualificationsWebSystem.ProgramService;
using QualificationsWebSystem.OpeningService;
using QualificationsWebSystem.TeacherModuleService;
using QualificationsWebSystem.ModuleService;
using AcademicsServicesDIPP;

namespace QualificationsWebSystem
{
    public partial class RegistrarPlanGlobal : System.Web.UI.Page
    {
        string nombrePrograma = string.Empty;
        string versionID = string.Empty;
        string nombreModulo = string.Empty;

        GlobalPlanAdminServiceClient proxy = null;
        AcademicServiceClient proxyProgram = null;
        OpeningProgramAdminServiceClient proxyOpening = null;
        TeacherModuleAdminServiceClient proxyTeacherMdoule = null;
        ModuleAdminServiceClient proxyModule = null;

        int version = 0;
        long programaID = 0;
        long moduloID = 0;
        long openingID = 0;
        long teachModuleID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
            proxyOpening = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            proxy = new GlobalPlanAdminServiceClient("WSHttpBinding_IGlobalPlanAdminService");
            proxyTeacherMdoule = new TeacherModuleAdminServiceClient("WSHttpBinding_ITeacherModuleAdminService");
            proxyModule = new ModuleAdminServiceClient("WSHttpBinding_IModuleAdminService");

            nombreModulo = Request.Params["ModuleName"].ToString();
            nombrePrograma = Request.Params["ProgramName"].ToString();
            versionID = Request.Params["ID"].ToString();

            Session["Modulo"] = nombreModulo;
            Session["Programa"] = nombrePrograma;
            Session["Version"] = versionID;

            //Obteniendo el ID del Programa Abierto
            version = GetVersion((string)Session["Version"]);
            //Obteniendo el ID del Programa
            programaID = proxyProgram.GetProgramID((string)Session["Programa"]);
            //Obteniendo el ID del OpeningProgram
            openingID = proxyOpening.GetOpeningID(programaID, version);
            //Obteniendo el ID del Modulo
            moduloID = proxyModule.GetModuleID((string)Session["Modulo"]);
            //Obteniendo el ID de la Asignación Docente Módulo
            teachModuleID = proxyTeacherMdoule.GetTeacherModule(moduloID, openingID);
            //lbl_Mensaje.Text = "Hasta aqui todo OK" + teachModuleID;
            Session["TeachingModule"] = teachModuleID + "";

            lbl_ProgramaPostgrado.Text = "MÓDULO: " + nombreModulo;
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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarFundamentacion.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarObjetivosEspecificos.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarMétodosEnseñanza.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarContenidoTematico.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarMétodosAprendizaje.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarFormasEvaluacion.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarBibliografía.aspx");
        }
    }
}