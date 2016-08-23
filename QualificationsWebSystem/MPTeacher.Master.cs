using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QualificationsWebSystem.AuthenticationService;
using AcademicsServicesDIPP;
using System.Data.Linq.SqlClient;
using System.Data.Entity;

namespace QualificationsWebSystem
{
    public partial class MPTeacher : System.Web.UI.MasterPage
    {
        AuthenticationServiceClient proxyAuthent = null;
        long UserID = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["rol"] != null)
            {
                int rol = int.Parse((string)Session["rol"]);
                switch (rol)
                {
                    case 1:
                        Response.Redirect("MenuAdministrador.aspx");
                        break;
                    case 2:

                        break;
                    case 3:
                        string nombreUsuario = string.Empty;
                        string rolUsuario = string.Empty;

                        string logIn = (string)Session["Cuenta"];
                        string Password = (string)Session["Contraseña"];

                        proxyAuthent = new AuthenticationServiceClient("WSHttpBinding_IAuthenticationService");
                        UserID = proxyAuthent.GetID(logIn, Password);
                        Session["UserID"] = UserID + "";

                        if (UserID != 0)
                        {
                            nombreUsuario = proxyAuthent.GetPerson(UserID);
                            rolUsuario = proxyAuthent.GetRole(3);
                            lbl_welcome.Text = rolUsuario + ":  " + nombreUsuario + " ";
                        }
                        else
                            Response.Redirect("Authentication.aspx");
                        break;
                    case 4:
                        Response.Redirect("CalificacionesEstudiante.aspx");
                        break;
                }
            }
            else
                Response.Redirect("Authentication.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Authentication.aspx");
            Session["rol"] = null;
        }
    }
}