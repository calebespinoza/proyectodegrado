using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq.SqlClient;
using System.Data.SqlClient;
using AcademicsServicesDIPP;

namespace QualificationsWebSystem
{
    public partial class ListaDocenteModulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lista();
        }

        public void Lista()
        {
            using (var context = new QualificationsDBEntities())
            {
                var teachmod = from tm in context.TeachingModule
                               join u in context.UserAccount
                               on tm.Teacher equals u.UserAccountId
                               join p in context.Person
                               on u.UserAccountId equals p.PersonId
                               join op in context.OpeningProgram
                               on tm.OpeningCode equals op.OpeningCode
                               join m in context.Module
                               on tm.ModuleCode equals m.ModuleCode
                               join gp in context.GraduateProgram
                               on op.ProgramId equals gp.GraduateProgramaId
                               join v in context.Version
                               on op.Version equals v.ID
                               select new
                               {
                                   Docente = p.Name + " " + p.FirstName + " " +p.LastName,
                                   Módulo = m.ModuleName,
                                   Programa = gp.ProgramName,
                                   Versión = v.ProgramVersion,
                                   Inicio = tm.ModuleStartDate,
                                   Fin = tm.ModuleEndDate
                               };
                GridView1.DataSource = teachmod;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Lista();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string value = TextBox1.Text;
            using (var context = new QualificationsDBEntities())
            {
                var teachmod = from tm in context.TeachingModule
                               join u in context.UserAccount
                               on tm.Teacher equals u.UserAccountId
                               join p in context.Person
                               on u.UserAccountId equals p.PersonId
                               join op in context.OpeningProgram
                               on tm.OpeningCode equals op.OpeningCode
                               join m in context.Module
                               on tm.ModuleCode equals m.ModuleCode
                               join gp in context.GraduateProgram
                               on op.ProgramId equals gp.GraduateProgramaId
                               join v in context.Version
                               on op.Version equals v.ID
                               where m.ModuleName == value
                               orderby p.Name.Substring(0,1) ascending
                               select new
                               {
                                   Docente = p.Name + " " + p.FirstName + " " + p.LastName,
                                   Módulo = m.ModuleName,
                                   Programa = gp.ProgramName,
                                   Versión = v.ProgramVersion,
                                   Inicio = tm.ModuleStartDate,
                                   Fin = tm.ModuleEndDate
                               };
                GridView1.DataSource = teachmod;
                GridView1.DataBind();
            }

        }
    }
}