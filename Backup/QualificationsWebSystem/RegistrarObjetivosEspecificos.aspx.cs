using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicsServicesDIPP;
using QualificationsWebSystem.GlobalPlanService;

namespace QualificationsWebSystem
{
    public partial class RegistrarObjetivosEspecificos : System.Web.UI.Page
    {
        GlobalPlanAdminServiceClient proxy = null;
        ObjectivesSpecifics entity = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new GlobalPlanAdminServiceClient("WSHttpBinding_IGlobalPlanAdminService");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            entity = new ObjectivesSpecifics();
            if (txt_Objetivos.Text != "")
            {
                long globalplanId = 0;
                long teachmodId = long.Parse((string)Session["TeachingModule"]);

                globalplanId = proxy.GetGlobalPlan(teachmodId);
                Session["GlobalPlanID"] = globalplanId;
                try
                {
                    entity.Number = 1;
                    entity.Description = txt_Objetivos.Text;
                    entity.GlobalPlan = globalplanId;
                    proxy.InsertObjectives(entity);
                    lbl_Mensaje.Text = "ÉXITO. Los datos han sido registrados correctamente.";
                    Componentes1(false);
                    Componentes2(true);
                }
                catch (Exception ex)
                {
                    lbl_Mensaje.Text = "ERROR. Los datos no han sido registrados.";
                }
            }
        }

        public void Componentes1(bool value)
        {
            Label4.Visible = value;
            txt_Objetivos.Visible = value;
            Button1.Visible = value;
        }

        public void Componentes2(bool value)
        {
            LinkButton1.Visible = value;
            LinkButton2.Visible = value;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            lbl_Mensaje.Text = "";
            txt_Objetivos.Text = "";
            Componentes1(true);
            Componentes2(false);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("");
        }
    }
}