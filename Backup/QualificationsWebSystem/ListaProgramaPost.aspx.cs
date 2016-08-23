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
    public partial class ListaProgramaPost : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DV41117NR\\SQLEXPRESS2008;Initial Catalog=QualificationsDB;User ID=sa;Password=123qwe;"))
            {
                QualificationsDBEntities context = new QualificationsDBEntities();
                var program = from p in context.GraduateProgram 
                              join ltp in context.ListTypeProgram on p.Type equals ltp.ListType

                           select new { NombrePrograma = p.ProgramName, 
                                        Tipo = ltp.TypeProgram, 
                                        Objetivo = p.Objective, 
                                        Perfil = p.Profile, 
                                        Requisitos = p.AdmissionRequeriments, 
                                        Matrícula =  p.ResgistrationCost };

                GridView1.DataSource = program;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}