using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicsServicesDIPP;
using QualificationsWebSystem.ModuleService;
using QualificationsWebSystem.ProgramService;
using QualificationsWebSystem.ModuleAsignationService;


namespace QualificationsWebSystem
{
    public partial class ModificarModulo : System.Web.UI.Page
    {
        ModuleAdminServiceClient proxyModule = null;
        AcademicServiceClient proxyProgram = null;
        ModuleAsigAdminServiceClient proxyAsignation = null;
        Module updateModule = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxyModule = new ModuleAdminServiceClient("WSHttpBinding_IModuleAdminService");
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
            proxyAsignation = new ModuleAsigAdminServiceClient("WSHttpBinding_IModuleAsigAdminService");

            updateModule = new Module();
            long moduleID = proxyModule.GetModuleID(Request.Params["ModuleName"].ToString());

            updateModule = Get(moduleID);

            if (!IsPostBack)
            {
                int count = 0;
                txt_ModuleName.Text = updateModule.ModuleName;

                using (var context = new QualificationsDBEntities())
                {
                    var program = from p in context.GraduateProgram
                                  orderby p.ProgramName.Substring(0, 1) ascending
                                  select p;

                    foreach (var query in program)
                    {
                        //Añadiendo al DropDownList con los nombres de los Programas de Postgrado
                        ddl_Programas.Items.Insert(count, query.ProgramName);
                        count = count + 1;
                    }
                }
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombrePrograma = ddl_Programas.SelectedValue;
            if (txt_ModuleName.Text != "")
            {
                if (nombrePrograma != "")
                {
                    long ProgramaID = 0;
                    long ModuloID = 0;

                    //pensum = new Pensum();

                    try
                    {
                        updateModule.ModuleName = txt_ModuleName.Text;
                        updateModule.Mode = rbl_Mode.SelectedValue.ToString();
                        UpdateModule(updateModule);
                        //Obteniendo el ID del Programa Seleccionado
                        //ProgramaID = proxyProgram.GetProgramID(nombrePrograma);


                        ////Registrando en la Tabla Pensum
                        //pensum.GraduateProgram = ProgramaID;
                        //pensum.ModuleCode = updateModule.ModuleCode;
                        //proxyAsignation.InsertAsignation(pensum);

                        lbl_mensaje.Text = "Módulo Modificado Exitosamente";
                        txt_ModuleName.Text = "";
                    }
                    catch (Exception ex)
                    {
                        lbl_mensaje.Text = "Ocurrio un problema inesperado. El Módulo no se ha modificado";
                    }
                }
                else
                    lbl_mensaje.Text = "Seleccione un Programa de Postgrado";
            }
            else
                lbl_mensaje.Text = "Ingrese los datos en todos los campos de texto.";
        }

        public Module Get(long ID)
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.Module.FirstOrDefault(x => x.ModuleCode == ID);
            }
        }

        public void UpdateModule(Module entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.Module.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
                context.SaveChanges();
            }
        }
    }
}