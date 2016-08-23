using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq.SqlClient;
using AcademicsServicesDIPP;
using QualificationsWebSystem.OpeningService;
using QualificationsWebSystem.TeacherModuleService;
using QualificationsWebSystem.StudentModuleService;//5

namespace QualificationsWebSystem
{
    public partial class RegistrarInscripción : System.Web.UI.Page
    {
        long personID = 0;
        long programID = 0;
        int versionID = 0;
        long moduloID = 0;
        long openingID = 0;
        long teamodID = 0;//11

        string carnet = string.Empty;
        OpeningProgramAdminServiceClient proxyOpening = null;
        TeacherModuleAdminServiceClient proxyTeachMod = null;
        StudentModuleAdminServiceClient proxyStudMod = null;

        StudentModule entity = null; //16
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_Estudiante.Text = Request.Params["IdentityCard"].ToString();

            proxyOpening = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            proxyTeachMod = new TeacherModuleAdminServiceClient("WSHttpBinding_ITeacherModuleAdminService");
            proxyStudMod = new StudentModuleAdminServiceClient("WSHttpBinding_IStudentModuleAdminService");

            if (!IsPostBack)
            {
                Programas();
                
            }
            carnet = Request.Params["IdentityCard"].ToString();
            personID = Estudiante(carnet);
        }

        public long Estudiante(string ci)
        {
            int value = int.Parse(ci);
            long id = 0;
            using (var context = new QualificationsDBEntities())
            {
                var person = from p in context.Person
                             where p.IdentityCard == value
                             select p;
                foreach (var query in person)
                {
                    id = query.PersonId;
                    lbl_Estudiante.Text = "Nombre del Estudiante : " + query.Name + " " + query.FirstName + " " + query.LastName;
                }
            }
            return id;
        }

        public void Programas()
        {
            using (var context = new QualificationsDBEntities())
            {
                var programas = from p in context.GraduateProgram
                                orderby p.ProgramName.Substring(0,1) ascending
                                select new
                                {
                                    ID = p.GraduateProgramaId,
                                    Name = p.ProgramName
                                };
                ddl_Programas.DataSource = programas;
                ddl_Programas.DataTextField = "Name";
                ddl_Programas.DataValueField = "ID";
                ddl_Programas.DataBind();

            }
            programID = long.Parse(ddl_Programas.SelectedValue);
            Versiones(programID);
        }

        public void Versiones(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
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

        public void Modulos(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var pensum = from p in context.Pensum
                             join m in context.Module
                             on p.ModuleCode equals m.ModuleCode
                             join pr in context.GraduateProgram
                             on p.GraduateProgram equals pr.GraduateProgramaId
                             where p.GraduateProgram == id
                             orderby m.ModuleName.Substring(0, 1) ascending
                             select new
                             {
                                 ID = m.ModuleCode,
                                 Modulo = m.ModuleName
                             };

                CheckBoxListMoldulos.DataSource = pensum;
                CheckBoxListMoldulos.DataTextField = "Modulo";
                CheckBoxListMoldulos.DataValueField = "ID";
                CheckBoxListMoldulos.DataBind();
                int cont = 0;
                foreach (var moduleid in pensum)
                {
                    BeforeSelectedModule(moduleid.ID, cont);
                    cont++;
                }
            }

            
            /*
            * for recorre todas las materias
             * {
             * for recorrer toda la lista de check box j
             * {
             *    if(CheckBoxListMoldulos.Items[j].Value == i
             *    {
             *      CheckBoxListMoldulos.Items[i].Selected = true;
             *    }
             * }
             * }
            */
        }

        public void BeforeSelectedModule(long idModule, int contador)
        {
            for (int i = 0; i < ddl_Versiones.Items.Count; i++)
            {
                programID = long.Parse(ddl_Programas.SelectedValue);
                versionID = int.Parse(ddl_Versiones.Items[i].Value);
                openingID = proxyOpening.GetOpeningID(programID, versionID);
                moduloID = idModule;
                personID = Estudiante(carnet);
                int cont = contador;
                using (var context = new QualificationsDBEntities())
                {
                    var studentmodule = from sm in context.StudentModule
                                        join tm in context.TeachingModule
                                        on sm.TeachingModuleCode equals tm.TeachingModuleCode
                                        join op in context.OpeningProgram
                                        on tm.OpeningCode equals op.OpeningCode
                                        where op.Version == versionID
                                        select new
                                        {
                                            tmID = sm.TeachingModuleCode,
                                            sID = sm.Student
                                        };
                    foreach (var x in studentmodule)
                    {
                        teamodID = proxyTeachMod.GetTeacherModule(moduloID, openingID);
                        if (x.tmID == teamodID && x.sID == personID)
                        {
                            CheckBoxSelectAll.Enabled = false;
                            CheckBoxListMoldulos.Items[cont].Enabled = false;
                        }
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            programID = long.Parse(ddl_Programas.SelectedValue);
            lbl_NombrePrograma.Text = "Programa de Postgrado : "+ddl_Programas.SelectedItem.ToString();
            ComponentesGraficos1(false);
            ComponentesGraficos2(true);
            //Versiones(programID);
            Modulos(programID); //60

        }

        public void ComponentesGraficos1(bool value)
        {
            Label5.Visible = value;
            ddl_Programas.Visible = value;
            ddl_Versiones.Visible = value;
            Label6.Visible = value;
            Button1.Visible = value;
            CheckBoxListMoldulos.Visible = value;

        }

        public void ComponentesGraficos2(bool value)
        {
            LinkButton2.Visible = value;
            //Label6.Visible = value;
            //ddl_Versiones.Visible = value;
            Label7.Visible = value;
            CheckBoxSelectAll.Visible = value;
            btn_Inscribir.Visible = value;
            CheckBoxListMoldulos.Visible = value;
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            lbl_NombrePrograma.Text = "";
            ComponentesGraficos1(true);
            ComponentesGraficos2(false);
            
        }

        protected void btn_Inscribir_Click(object sender, EventArgs e)
        {
           
            //eliminas todos los modulos del estudiante
            for (int i = 0; i < CheckBoxListMoldulos.Items.Count; i++)
            {
                if (CheckBoxListMoldulos.Items[i].Selected == true) 
                {
                    Insert(CheckBoxListMoldulos.Items[i].Value);
                }
            }
            
        }
        public void Insert(string valueModulo) 
        {
            programID = long.Parse(ddl_Programas.SelectedValue);
            versionID = int.Parse(ddl_Versiones.SelectedValue);
            openingID = proxyOpening.GetOpeningID(programID, versionID);
            moduloID = long.Parse(valueModulo);
            personID = Estudiante(carnet);

            if (openingID != 0)
            {
                entity = new StudentModule();
                teamodID = proxyTeachMod.GetTeacherModule(moduloID, openingID);

                if (teamodID != 0)
                {
                    try
                    {
                        entity.TeachingModuleCode = teamodID;
                        entity.Student = personID;

                        proxyStudMod.InsertStudentModule(entity);

                        lbl_Mensaje.Text = "ÉXITO. El / La Estudiante ha sido inscrito !";
                    }
                    catch (Exception ex)
                    {
                        lbl_Mensaje.Text = "ERROR. El / La Estudiante no ha sido inscrito";//88
                    }
                }
                else
                    lbl_Mensaje.Text = "Éste módulo no tiene un docente asignado";
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < CheckBoxListMoldulos.Items.Count; i++)
            {
                if (CheckBoxSelectAll.Checked==true) 
                {
                    CheckBoxListMoldulos.Items[i].Selected = true;
                }
                else
                {
                    CheckBoxListMoldulos.Items[i].Selected = false;
                }
            }
        }

        protected void ddl_Versiones_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        protected void ddl_Programas_SelectedIndexChanged(object sender, EventArgs e)
        {
            programID = long.Parse(ddl_Programas.SelectedValue);
            Versiones(programID);
        }
    }
}