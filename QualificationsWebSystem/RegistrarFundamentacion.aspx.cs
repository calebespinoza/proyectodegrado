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
    public partial class RegistrarFundamentacion : System.Web.UI.Page
    {
        GlobalPlanAdminServiceClient proxy = null;
        AcademicServiceClient proxyProgram = null;
        OpeningProgramAdminServiceClient proxyOpening = null;
        TeacherModuleAdminServiceClient proxyTeacherMdoule = null;
        ModuleAdminServiceClient proxyModule = null;

        GlobalPlan entity = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
            proxyOpening = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            proxy = new GlobalPlanAdminServiceClient("WSHttpBinding_IGlobalPlanAdminService");
            proxyTeacherMdoule = new TeacherModuleAdminServiceClient("WSHttpBinding_ITeacherModuleAdminService");
            proxyModule = new ModuleAdminServiceClient("WSHttpBinding_IModuleAdminService");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int version = 0;
            long programaID = 0;
            long moduloID = 0;
            long openingID = 0;
            long teachModuleID = 0;
            //long userID = long.Parse((string)Session["UserID"]);
            entity = new GlobalPlan();

            if (txt_Fundamentacion.Text != "")
            {
                if (txt_Objetivo.Text != "")
                {
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
                    try
                    {
                        entity.TeachingModuleCode = teachModuleID;
                        entity.Foundamentation = txt_Fundamentacion.Text;
                        entity.GeneralObjective = txt_Objetivo.Text;
                        entity.Status = 1;
                        entity.Fecha = DateTime.Now;

                        proxy.InsertGlobalPlan(entity);
                        lbl_Mensaje.Text = "ÉXITO. Los datos han sido registrados.";
                        Button1.Visible = false;
                        txt_Fundamentacion.Text = "";
                        txt_Objetivo.Text = "";
                        LinkButton1.Visible = true;
                        Label4.Visible = false;
                        txt_Fundamentacion.Visible = false;
                        txt_Objetivo.Visible = false;
                        Label5.Visible = false;
                    }
                    catch(Exception ex)
                    {
                        lbl_Mensaje.Text = "ERROR. Los datos no han sido registrados.";
                    }
                }
                else
                    lbl_Mensaje.Text = "Registre el Objetivo General del Módulo.";
            }
            else
                lbl_Mensaje.Text = "Escriba la Fundamentación.";

        }

        public int GetVersion(string description)
        {
            int ID = 0;
            using (var context = new QualificationsDBEntities())
            {
                var version = from v in context.Version 
                              where v.ProgramVersion == description select v;
                foreach (var query in version)
                {
                    ID = query.ID;
                }
            }
            return ID;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarObjetivosEspecificos.aspx");
        }
    }
}