using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicsServicesDIPP;

namespace QualificationsWebSystem
{
    public partial class ListaInscripciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Reporte();
        }

        public void Reporte()
        {
            using (var context = new QualificationsDBEntities())
            {
                var reporte = from sm in context.StudentModule
                              join p in context.Person
                              on sm.Student equals p.PersonId
                              join tm in context.TeachingModule
                              on sm.TeachingModuleCode equals tm.TeachingModuleCode
                              join op in context.OpeningProgram
                              on tm.OpeningCode equals op.OpeningCode
                              join m in context.Module
                              on tm.ModuleCode equals m.ModuleCode
                              join gp in context.GraduateProgram
                              on op.ProgramId equals gp.GraduateProgramaId
                              join v in context.Version
                              on op.Version equals v.ID
                              orderby p.Name.Substring(0,1) ascending
                              select new
                              {
                                  Nombre = p.Name,
                                  Paterno = p.FirstName,
                                  Materno = p.LastName,
                                  Módulo = m.ModuleName,
                                  Programa = gp.ProgramName,
                                  Versión = v.ProgramVersion
                              };
                GridView1.DataSource = reporte;
                GridView1.DataBind();
            }
        }

        public void BuscarReporte(string name)
        {
            using (var context = new QualificationsDBEntities())
            {
                var reporte = from sm in context.StudentModule
                              join p in context.Person
                              on sm.Student equals p.PersonId
                              join tm in context.TeachingModule
                              on sm.TeachingModuleCode equals tm.TeachingModuleCode
                              join op in context.OpeningProgram
                              on tm.OpeningCode equals op.OpeningCode
                              join m in context.Module
                              on tm.ModuleCode equals m.ModuleCode
                              join gp in context.GraduateProgram
                              on op.ProgramId equals gp.GraduateProgramaId
                              join v in context.Version
                              on op.Version equals v.ID
                              where p.Name.Contains(name) || p.FirstName.Contains(name)
                              orderby p.Name.Substring(0, 1) ascending
                              select new
                              {
                                  Nombre = p.Name,
                                  Paterno = p.FirstName,
                                  Materno = p.LastName,
                                  Módulo = m.ModuleName,
                                  Programa = gp.ProgramName,
                                  Versión = v.ProgramVersion
                              };
                GridView1.DataSource = reporte;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Reporte();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string value = TextBox1.Text;
            BuscarReporte(value);
        }
    }
}