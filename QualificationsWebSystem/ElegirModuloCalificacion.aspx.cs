using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicsServicesDIPP;

namespace QualificationsWebSystem
{
    public partial class RegistrarCalificacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lista();
        }

        public void Lista()
        {
            string cuenta = (string)Session["Cuenta"];
            string contra = (string)Session["Contraseña"];
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
                               where u.Account == cuenta & u.Password == contra
                               select new
                               {
                                   //Docente = p.Name + " " + p.FirstName + " " +p.LastName,
                                   Módulo = m.ModuleName,
                                   Programa = gp.ProgramName,
                                   Versión = v.ProgramVersion
                               };
                GridView1.DataSource = teachmod;
                GridView1.DataBind();
            }
        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}