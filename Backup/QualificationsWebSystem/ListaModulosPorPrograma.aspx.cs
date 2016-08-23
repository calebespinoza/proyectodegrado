using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Linq.SqlClient;
using AcademicsServicesDIPP;
using System.Data.Entity;
using QualificationsWebSystem.ProgramService;
using QualificationsWebSystem.ModuleService;
using QualificationsWebSystem.ModuleAsignationService;

namespace QualificationsWebSystem
{
    public partial class RegistrarModuloPrograma : System.Web.UI.Page
    {
        long ProgramaID = 0;
        bool value = false;
        AcademicServiceClient proxyProgram = null;
        ModuleAdminServiceClient proxyModule = null;
        ModuleAsigAdminServiceClient proxyAsignation = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(value == false)
            {
                int count = 0;

                proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
                proxyModule = new ModuleAdminServiceClient("WSHttpBinding_IModuleAdminService");
                proxyAsignation = new ModuleAsigAdminServiceClient("WSHttpBinding_IModuleAsigAdminService");

                using (var context = new QualificationsDBEntities())
                {
                    //QualificationsDBEntities context = new QualificationsDBEntities();
                    var program = from p in context.GraduateProgram
                                  orderby p.ProgramName.Substring(0, 1) ascending
                                  select p;

                    foreach (var query in program)
                    {
                        //Añadiendo al DropDownList con los nombres de los Programas de Postgrado
                        //ddl_Programas.Items.Insert(count, query.ProgramName);
                        count = count + 1;
                    }
                    //Session["valuePensum"] = "true"; //inicializado en el WebForm Authentication
                } 
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            value = true;
            string nombrePrograma = ddl_Programas.SelectedValue;
            if (nombrePrograma != "")
            {
                ProgramaID = proxyProgram.GetProgramID(nombrePrograma);
                using (var context = new QualificationsDBEntities())
                {
                    //QualificationsDBEntities context = new QualificationsDBEntities();
                    var pensum = from p in context.Pensum
                                 join m in context.Module
                                 on p.ModuleCode equals m.ModuleCode
                                 join pr in context.GraduateProgram
                                 on p.GraduateProgram equals pr.GraduateProgramaId
                                 where p.GraduateProgram == ProgramaID
                                 orderby m.ModuleName.Substring(0, 1) ascending
                                 select new
                                 {
                                     Modulo = m.ModuleName,
                                     Modalidad = m.Mode
                                 };
                    GridView1.DataSource = pensum;
                    GridView1.DataBind();
                }
            }
            //ddl_Programas.Items.Clear();
        }

        protected void ddl_Programas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}