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
    public partial class RegistrarContenidoTematico : System.Web.UI.Page
    {
        GlobalPlanAdminServiceClient proxyGP = null;

        ContentThematic entity = null;
        StatusThemeContent status = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            proxyGP = new GlobalPlanAdminServiceClient("WSHttpBinding_IGlobalPlanAdminService");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            entity = new ContentThematic();
            status = new StatusThemeContent();
            if (txt_Tema.Text != "" || txt_ObjInstrumental.Text != "")
            {
                try
                {
                    entity.Theme = txt_Tema.Text;
                    entity.InstrumentalObjectives = txt_ObjInstrumental.Text;
                    if (txt_TemaInvest.Text != "")
                        entity.InvestigationThemes = txt_TemaInvest.Text;
                    else
                        entity.InvestigationThemes = null;

                    if (txt_TrabPersonal.Text != "")
                        entity.PersonalWork = txt_TrabPersonal.Text;
                    else
                        entity.PersonalWork = null;

                    if (txt_TrabGrupal.Text != "")
                        entity.GroupWork = txt_TrabGrupal.Text;
                    else
                        entity.GroupWork = null;

                    entity.GlobalPlan = (long)Session["GlobalPlanID"];
                    proxyGP.InsertThematicContent(entity);

                    status.StatusThemeCode = 0;
                    status.ContentCode = ThematicContentID((long)Session["GlobalPlanID"]);
                    status.Date = DateTime.Now;
                    proxyGP.InsertStatusThematicContent(status);
                    

                    lbl_mensaje.Text = "ÉXITO. Los datos se han guardado correctamente.";
                    ComponentesGraficos1(false);
                    ComponentesGraficos2(true);

                }
                catch (Exception ex)
                {
                    lbl_mensaje.Text = "ÉRROR. Los datos NO se han guardado.";
                }
            }
            else
                lbl_mensaje.Text = "Introduzca datos en los campos marcados con * (asterisco)";
        }

        public void ComponentesGraficos1(bool value)
        {
            Label4.Visible = value;
            Label5.Visible = value;
            Label6.Visible = value;
            Label7.Visible = value;
            Label8.Visible = value;

            txt_Tema.Visible = value;
            txt_ObjInstrumental.Visible = value;
            txt_TemaInvest.Visible = value;
            txt_TrabGrupal.Visible = value;
            txt_TrabPersonal.Visible = value;

            Button1.Visible = value;
        }

        public void ComponentesGraficos2(bool value)
        {
            LinkButton1.Visible = value;
            LinkButton2.Visible = value;
        }

        public long ThematicContentID(long GlobalPlanId)
        {
            long code = 0;
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.GlobalPlan
                            join t in context.ContentThematic
                            on q.GlobalPlanCode equals t.GlobalPlan
                            where t.GlobalPlan == GlobalPlanId
                            select new
                            {
                                t.Code
                            };
                foreach (var id in query)
                {
                    code = id.Code;
                }
            }
            return code;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            ComponentesGraficos1(true);
            ComponentesGraficos2(false);
            lbl_mensaje.Text = "";
            txt_Tema.Text = "";
            txt_ObjInstrumental.Text = "";
            txt_TemaInvest.Text = "";
            txt_TrabGrupal.Text = "";
            txt_TrabPersonal.Text = "";
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarMétodosEnseñanza.aspx");
        }
    }
}