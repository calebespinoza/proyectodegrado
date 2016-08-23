using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicsServicesDIPP;
using System.Data.Linq.SqlClient;
using System.Data.Entity;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace QualificationsWebSystem
{
    public partial class ListaEstudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DV41117NR\\SQLEXPRESS2008;Initial Catalog=QualificationsDB;User ID=sa;Password=123qwe;"))
            {
                QualificationsDBEntities context = new QualificationsDBEntities();
                var user = from u in context.UserAccount
                           join p in context.Person
                                on u.UserAccountId equals p.PersonId
                           join ust in context.ListAccountStatus
                                on u.AccountStatus equals ust.UserStatusCode
                           join urole in context.UserRole
                                on u.UserAccountId equals urole.UserAccountId
                           join lr in context.ListRole
                                on urole.RoleCode equals lr.RoleCode
                           where urole.RoleCode == 4
                           select new
                           {
                               Nombre = p.Name,
                               Paterno = p.FirstName,
                               Materno = p.LastName,
                               Profesión = p.Profession,
                               CI = p.IdentityCard,
                               Sexo = p.Sex,
                               Celular = p.MobilePhone,
                               Teléfono = p.HomePhone,
                               Domicilio = p.HomeAddress,
                               Email = p.Email,
                               CódigoPostal = p.PostalCode,
                               Actualización = p.VersionDate,
                               Estado = ust.UserStatusDescription,
                               Rol = lr.RolDescription
                           };
                GridView1.DataSource = user;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}