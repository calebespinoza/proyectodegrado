using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Linq.SqlClient;
using AcademicsServicesDIPP;

namespace QualificationsWebSystem
{
    public partial class ListaProgramasCerrados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlCommand con = new SqlCommand("Data Source=DV41117NR\\SQLEXPRESS2008;Initial Catalog=QualificationsDB;User ID=sa;Password=123qwe;"))
            {
                QualificationsDBEntities context = new QualificationsDBEntities();

                var openProgram = from op in context.OpeningProgram
                                  join p in context.GraduateProgram
                                  on op.ProgramId equals p.GraduateProgramaId
                                  join v in context.Version
                                  on op.Version equals v.ID
                                  join s in context.StatusOpening
                                  on op.Status equals s.ID
                                  where op.Status == 0
                                  orderby v.ID
                                  select new
                                  {
                                      ProgramaPostgrado = p.ProgramName,
                                      Versión = v.ProgramVersion,
                                      Inicio = op.StartDate,
                                      Finalización = op.EndDate,
                                      Gestión = op.Gestion,
                                      Estado = s.Description

                                  };
                GridView1.DataSource = openProgram;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}