using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Linq.SqlClient;
using AcademicsServicesDIPP;
using QualificationsWebSystem.ProgramService;
using QualificationsWebSystem.OpeningService;
using QualificationsWebSystem.TeacherModuleService;

namespace QualificationsWebSystem
{
    public partial class RegistrarDocenteModulo : System.Web.UI.Page
    {
        AcademicServiceClient proxyProgram = null;
        TeacherModuleAdminServiceClient proxyTModule = null;
        OpeningProgramAdminServiceClient proxyOpening = null;
        TeachingModule entity = null;
        long[] index;
        string[] nameProgram;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            nameProgram = new string[100];
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
            proxyTModule = new TeacherModuleAdminServiceClient("WSHttpBinding_ITeacherModuleAdminService");
            proxyOpening = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            
            if(!IsPostBack)
            {
                ProgramasPostgrado();
            }
        }
        public void ProgramasPostgrado()
        {
            using (SqlConnection con = new SqlConnection("Data Source=DV41117NR\\SQLEXPRESS2008;Initial Catalog=QualificationsDB;User ID=sa;Password=123qwe;"))
            {
                QualificationsDBEntities context = new QualificationsDBEntities();
                var program = from p in context.GraduateProgram
                              orderby p.ProgramName.Substring(0,1) ascending
                              select new
                              {
                                  ID = p.GraduateProgramaId,
                                  Nombre = p.ProgramName,
                              };
                ddl_Programas.DataSource = program;
                ddl_Programas.DataTextField = "Nombre";
                ddl_Programas.DataValueField = "ID";
                ddl_Programas.DataBind();
            }
        }

        public void versiones(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                //QualificationsDBEntities context = new QualificationsDBEntities();
                var openprogram = from op in context.OpeningProgram
                                  join p in context.GraduateProgram
                                  on op.ProgramId equals p.GraduateProgramaId
                                  join v in context.Version
                                  on op.Version equals v.ID
                                  join s in context.StatusOpening
                                  on op.Status equals s.ID
                                  where op.Status == 1 && op.ProgramId == id
                                  orderby v.ID
                                  select new
                                  {
                                      ID = v.ID,
                                      Version = v.ProgramVersion
                                  };
                ddl_Versiones.DataSource = openprogram;
                ddl_Versiones.DataTextField = "Version";
                ddl_Versiones.DataValueField = "ID";
                ddl_Versiones.DataBind();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            long id = long.Parse(ddl_Programas.SelectedValue);
            Label9.Text = ddl_Programas.SelectedItem.ToString();

            versiones(id);
            modulos(id);
            docentes();

            ComponentesGraficos1(false);
            ComponentesGráficos2(true);
            
        }

        public void modulos(long ProgramaID)
        {
            int count = 0;

            using (SqlConnection con = new SqlConnection("Data Source=DV41117NR\\SQLEXPRESS2008;Initial Catalog=QualificationsDB;User ID=sa;Password=123qwe;"))
            {
                QualificationsDBEntities context = new QualificationsDBEntities();
                var pensum = from p in context.Pensum
                             join m in context.Module
                             on p.ModuleCode equals m.ModuleCode
                             join pr in context.GraduateProgram
                             on p.GraduateProgram equals pr.GraduateProgramaId
                             where p.GraduateProgram == ProgramaID
                             orderby m.ModuleName.Substring(0, 1) ascending
                             select new
                             {
                                 ID = m.ModuleCode,
                                 Modulo = m.ModuleName
                             };

                ddl_Modulos.DataSource = pensum;
                ddl_Modulos.DataTextField = "Modulo";
                ddl_Modulos.DataValueField = "ID";
                ddl_Modulos.DataBind();
            }
        }


        public void docentes()
        {
            int count = 0;
            string nombre = string.Empty;
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
                           where urole.RoleCode == 3
                           orderby p.Name.Substring(0,1) ascending
                           select new
                           {
                               ID = p.PersonId,
                               nombre = p.Name+" "+p.FirstName+" "+p.LastName
                           };

                ddl_Docentes.DataSource = user;
                ddl_Docentes.DataTextField = "nombre";
                ddl_Docentes.DataValueField = "ID";
                ddl_Docentes.DataBind();
            }
        }


        public void programasPostgrado()
        {
            int count = 0;
            string nombre = string.Empty;
            using (SqlConnection con = new SqlConnection("Data Source=DV41117NR\\SQLEXPRESS2008;Initial Catalog=QualificationsDB;User ID=sa;Password=123qwe;"))
            {
                QualificationsDBEntities context = new QualificationsDBEntities();

                var user = from op in context.OpeningProgram
                           join p in context.GraduateProgram
                                on op.ProgramId equals p.GraduateProgramaId
                           join v in context.Version
                                on op.Version equals v.ID
                           join s in context.StatusOpening
                                on op.Status equals s.ID
                           where op.Status == 1
                           orderby v.ID
                           select new
                           {
                               ID = op.ProgramId,
                               nombre = op.ProgramId
                           };

                ddl_Programas.DataSource = user;
                ddl_Programas.DataTextField = "nombre";
                ddl_Programas.DataValueField = "ID";
                ddl_Programas.DataBind();
            }
        }

        protected void btn_Registrar_Click(object sender, EventArgs e)
        {
            //string docentes = ddl_Docentes.SelectedIndex.ToString();
            entity = new TeachingModule();
            long programaID = long.Parse(ddl_Programas.SelectedValue);
            int versionPrograma = int.Parse(ddl_Versiones.SelectedValue);
            long moduloID = long.Parse(ddl_Modulos.SelectedValue);
            long docenteID = long.Parse(ddl_Docentes.SelectedValue);
            long openingID = proxyOpening.GetOpeningID(programaID, versionPrograma);
            DateTime inicio = Calendar1.SelectedDate;
            DateTime fin = Calendar2.SelectedDate;

            try
            {
                entity.ModuleCode = moduloID;
                entity.Teacher = docenteID;
                entity.OpeningCode = openingID;
                entity.ModuleStartDate = inicio;
                entity.ModuleEndDate = fin;
                entity.Periods = 36;
                proxyTModule.InsertTeacherModule(entity);
                Label7.Text = "ÉXITO. Los datos han sido registrados !";
            }
            catch (Exception ex)
            {
                Label7.Text = "ERROR. Los datos no han sido registrados";
            }

            string programa = ddl_Programas.SelectedValue;


            //Label7.Text = "Programa = "+programaID+"; version = "+versionPrograma+"; Modulo = "+moduloID+"; Docente = "+docenteID+"; CodigoApertura = "+openingID+"; "+inicio+" "+fin;
        }

        protected void ddl_Programas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ComponentesGraficos1(bool value)
        {
            Label4.Visible = value;
            ddl_Programas.Visible = value;
            btn_Proceder.Visible = value;
        }

        public void ComponentesGráficos2 (bool value)
        {
            Label5.Visible = value;
            Label6.Visible = value;
            Label8.Visible = value;
            ddl_Versiones.Visible = value;
            ddl_Modulos.Visible = value;
            ddl_Docentes.Visible = value;
            LinkButton2.Visible = value;
            Label9.Visible = value;
            btn_Registrar.Visible = value;
            Calendar1.Visible = value;
            Calendar2.Visible = value;
            Label10.Visible = value;
            Label11.Visible = value;
            Label7.Text = "";
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            ComponentesGráficos2(false);
            ComponentesGraficos1(true);

            
        }
    }
}