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
    public partial class RegistrarMétodosEnseñanza : System.Web.UI.Page
    {
        GlobalPlanAdminServiceClient proxy = null;
        TeachingMethods entity = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new GlobalPlanAdminServiceClient("WSHttpBinding_IGlobalPlanAdminService");
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

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarMétodosEnseñanza.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            entity = new TeachingMethods();
            long globalplanId = 0;
            long teachmodId = long.Parse((string)Session["TeachingModule"]);

            globalplanId = proxy.GetGlobalPlan(teachmodId);
            Session["GlobalPlanID"] = globalplanId;

            if (txt_Método.Text != "")
            {
                if (txt_Justificacion.Text != "")
                {
                    if (txt_description.Text != "")
                    {
                        try
                        {
                            //lbl_Mensaje.Text = ""+globalplanId;
                            entity.MethodName = txt_Método.Text;
                            entity.Justification = txt_Justificacion.Text;
                            entity.Description = txt_Método.Text;
                            entity.PlanGlobal = globalplanId;
                            proxy.InsertTeachingMethods(entity);
                            lbl_Mensaje.Text = "ÉXITO. El método se ha guardado en la Base de Datos";
                            txt_description.Text = "";
                            txt_Justificacion.Text = "";
                            txt_Método.Text = "";
                            Componentes1(false);
                            Componentes2(true);
                        }
                        catch (Exception ex)
                        {
                            lbl_Mensaje.Text = "ERROR. El método no se ha guardado en la Base de Datos";
                        }
                    }
                    else
                        lbl_Mensaje.Text = "Escriba la Descripción";
                }
                else
                    lbl_Mensaje.Text = "Excriba la Justificación";
            }
            else
                lbl_Mensaje.Text = "Escriba el nombre del Método";
            
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Componentes1(true);
            Componentes2(false);
        }

        public void Componentes1(bool value)
        {
            Label4.Visible = value;
            txt_description.Visible = value;
            txt_Justificacion.Visible = value;
            txt_Método.Visible = value;
            Button1.Visible = value;
        }

        public void Componentes2(bool value)
        {
            LinkButton1.Visible = value;
            LinkButton2.Visible = value;
        }
    }
}