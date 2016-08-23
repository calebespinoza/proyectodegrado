using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QualificationsWebSystem.AuthenticationService;
using AcademicsServicesDIPP;
using System.Data;

namespace QualificationsWebSystem
{
    public partial class Authentication : System.Web.UI.Page
    {
        AuthenticationServiceClient proxy = null;
        string logIn = string.Empty;
        string pass = string.Empty;
        long value;

        protected void Page_Load(object sender, EventArgs e)
        {
            value = 0;
            proxy = new AuthenticationServiceClient("WSHttpBinding_IAuthenticationService");
            Session["value"] = "false";
            Session["DocenteModulo"] = "deshabilitado";
            LoginForm.Focus();
        }

        
        protected  void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            logIn = LoginForm.UserName;
            pass = LoginForm.Password;

            value = proxy.AuthenticateUser(logIn, pass);

            if (value != 0)
            {
                Session["Cuenta"] = logIn;
                Session["Contraseña"] = pass;
                Session["rol"] = value.ToString();


                switch (value)
                {
                    case 1:
                        Response.Redirect("MenuAdministrador.aspx");
                        break;

                    case 2:
                        //lblAdvertencia.Text = "Jefe de la DIPP";
                        break;

                    case 3:
                        Response.Redirect("MenuDocente.aspx");
                        break;

                    case 4:
                        Response.Redirect("CalificacionesEstudiante.aspx");
                        break;
                }
            }
        }

        public long GetUser()
        {
            return value;
        }

    }
}