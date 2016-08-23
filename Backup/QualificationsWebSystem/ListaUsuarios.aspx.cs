using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using QualificationsWebSystem.AuthenticationService;
using AcademicsServicesDIPP;
using System.Data.Linq.SqlClient;
using System.Data.Entity;

namespace QualificationsWebSystem
{
    public partial class ListaUsuarios : System.Web.UI.Page
    {
        
        //UserAccountAdminServiceClient proxy = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DV41117NR\\SQLEXPRESS2008;Initial Catalog=QualificationsDB;User ID=sa;Password=123qwe;"))
            {

                QualificationsDBEntities context = new QualificationsDBEntities();
                var admin = from u in context.UserAccount
                            join p in context.Person
                                 on u.UserAccountId equals p.PersonId
                            join ust in context.ListAccountStatus
                                 on u.AccountStatus equals ust.UserStatusCode
                            join urole in context.UserRole
                                 on u.UserAccountId equals urole.UserAccountId
                            join lr in context.ListRole
                                 on urole.RoleCode equals lr.RoleCode
                            where lr.RoleName == "Administrador" || lr.RoleName == "Jefe"
                            select new
                            {
                                Cuenta = u.Account,
                                Password = u.Password,
                                Nombre = p.Name,
                                ApellidoPaterno = p.FirstName,
                                ApellidoMaterno = p.LastName,
                                Profesión = p.Profession,
                                FechaCreación = p.CreateDate,
                                Actualización = p.VersionDate,
                                Estado = ust.UserStatusDescription,
                                Rol = lr.RolDescription
                            };
                GridView2.DataSource = admin;
                GridView2.DataBind();
            }

            GetAll();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void GetAll()
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
                           where lr.RoleName == "Docente" || lr.RoleName == "Estudiante"
                           select new
                           {
                               Cuenta = u.Account,
                               Password = u.Password,
                               Nombre = p.Name,
                               ApellidoPaterno = p.FirstName,
                               ApellidoMaterno = p.LastName,
                               Profesión = p.Profession,
                               FechaCreación = p.CreateDate,
                               Actualización = p.VersionDate,
                               Estado = ust.UserStatusDescription,
                               Rol = lr.RolDescription
                           };
                GridView1.DataSource = user;
                GridView1.DataBind();
            }
        }

        protected void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (txt_Criterio.Text == "")
            {
            }
            else
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
                               where p.Name.Contains(txt_Criterio.Text)
                               || p.FirstName.Contains(txt_Criterio.Text) 
                               & lr.RoleName == rbl_TipoUsuario.SelectedItem.Text
                               select new
                               {
                                   Cuenta = u.Account,
                                   Password = u.Password,
                                   Nombre = p.Name,
                                   ApellidoPaterno = p.FirstName,
                                   ApellidoMaterno = p.LastName,
                                   Profesión = p.Profession,
                                   FechaCreación = p.CreateDate,
                                   Actualización = p.VersionDate,
                                   Estado = ust.UserStatusDescription,
                                   Rol = lr.RolDescription
                               };
                    GridView1.DataSource = user;
                    GridView1.DataBind();
                }
            }
        }

        protected void btn_General_Click(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}