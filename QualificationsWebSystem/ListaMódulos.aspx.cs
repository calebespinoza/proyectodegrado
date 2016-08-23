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
using System.Data.Linq.SqlClient;

namespace QualificationsWebSystem
{
    public partial class ListaMódulos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListaGeneral();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListaGeneral();
        }

        public void ListaGeneral()
        {
            using (var contex = new QualificationsDBEntities())
            {
                //QualificationsDBEntities contex = new QualificationsDBEntities();
                var module = from m in contex.Module
                             join sm in contex.StatusModule
                             on m.Status equals sm.StatusModuleCode
                             orderby m.ModuleName.Substring(0,1) ascending
                             select new
                             {
                                 Modulo = m.ModuleName,
                                 Modalidad = m.Mode,
                                 Estado = sm.Description
                             };
                GridView1.DataSource = module;
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txt_criterio.Text != "")
            {
                using (var context = new QualificationsDBEntities())
                {
                    //QualificationsDBEntities context = new QualificationsDBEntities();
                    var module = from m in context.Module
                                 join sm in context.StatusModule
                                 on m.Status equals sm.StatusModuleCode
                                 where m.ModuleName.Contains(txt_criterio.Text)
                                 select new
                                 {
                                     Modulo = m.ModuleName,
                                     Modalidad = m.Mode,
                                     Estado = sm.Description
                                 };
                    GridView1.DataSource = module;
                    GridView1.DataBind();
                }
            }
        }
    }
}