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
    public partial class MPStudent : System.Web.UI.MasterPage
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
                        Response.Redirect("MenuDocente.aspx");
                        break;
                    case 4:
                        
                        string nombreUsuario = string.Empty;
                        string rolUsuario = string.Empty;

                        string logIn = (string)Session["Cuenta"];
                        string Password = (string)Session["Contraseña"];

                        proxyAuthent = new AuthenticationServiceClient("WSHttpBinding_IAuthenticationService");
                        UserID = proxyAuthent.GetID(logIn, Password);
                        

                        if (UserID != 0)
                        {
                            nombreUsuario = proxyAuthent.GetPerson(UserID);
                            rolUsuario = proxyAuthent.GetRole(4);
                            lbl_welcome.Text = rolUsuario + ":  " + nombreUsuario + " ";
                            Session["UserID"] = UserID;
                        }
                        else
                            Response.Redirect("Authentication.aspx");
                        
                        break;
                }
            }
            else
                Response.Redirect("Authentication.aspx");
        }
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    string value = string.Empty;
        //    string valueName = string.Empty;

        //    proxyAuthent = new AuthenticationServiceClient("WSHttpBinding_IAuthenticationService");

        //    var context = new QualificationsDBEntities();
        //    var user = from u in context.UserAccount
        //               join p in context.Person
        //                   on u.UserAccountId equals p.PersonId
        //               where u.Account == "jarispe"
        //               select new { p.Name, p.FirstName, p.LastName, u.Account };
        //    foreach (var query in user)
        //    {
        //        value = query.Name + " " + query.FirstName + " " + query.LastName;
        //    }
        //    valueName = proxyAuthent.GetRole(1);
        //    lbl_welcome.Text = valueName + ":  " + value + " ";
        //}

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Authentication.aspx");
            Session["rol"] = null;
        }
    }
}