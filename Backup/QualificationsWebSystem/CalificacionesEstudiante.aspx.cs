using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using AcademicsServicesDIPP;
using QualificationsWebSystem.AuthenticationService;

namespace QualificationsWebSystem
{
    public partial class CalificacionesEstudiante : System.Web.UI.Page
    {
        long userid = 0;
        string login = string.Empty;
        string pass = string.Empty;

        AuthenticationServiceClient proxy = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //userid = (long)Session["UserID"];
            proxy = new AuthenticationServiceClient("WSHttpBinding_IAuthenticationService");
            login = (string)Session["Cuenta"];
            pass = (string)Session["Contraseña"];
            long UserID = proxy.GetID(login, pass);
            //long userid = long.Parse((string)Session["UserID"]);
            Nombre(UserID);
            Reporte(UserID);
            Totales(UserID);
        }

        public void Nombre(long userid)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from p in context.Person
                            where p.PersonId == userid
                            select new
                            {
                                Nombre = p.Name +" "+p.FirstName+" "+p.LastName
                            };
                foreach (var name in query)
                {
                    lbl_Estudiante.Text = "Nombre: "+name.Nombre;
                }
                //var name in query

            }
        }

        public void Reporte(long userid)
        {
            
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.StudentModule
                            join p in context.Person
                            on q.Student equals p.PersonId
                            join tm in context.TeachingModule
                            on q.TeachingModuleCode equals tm.TeachingModuleCode
                            join qua in context.Qualifications
                            on q.StudentModuleCode equals qua.StudentModuleCode
                            join to in context.Totals
                            on q.StudentModuleCode equals to.Code
                            join pe in context.EvaluationPlan
                            on qua.EvaluationPlanCode equals pe.EvaluationCode
                            where q.Student == userid
                            select new
                            {
                                Descripción = pe.Description,
                                Calificación = qua.Qualification,
                                Fecha = pe.Date,
                                Ponderación = pe.Consideration
                            };
                GridView1.DataSource = query;
                GridView1.DataBind();
            }
        }

        public void Totales(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.StudentModule
                            join to in context.Totals
                            on q.StudentModuleCode equals to.Code
                            where q.Student == id
                            select new
                            {
                                CalificaciónParcial = to.TotalPartial,
                                CalificaciónFinal = to.TotalFinal,
                                Total = to.Total
                            };
                GridView2.DataSource = query;
                GridView2.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}