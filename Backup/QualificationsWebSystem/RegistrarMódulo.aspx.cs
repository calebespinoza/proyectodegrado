using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QualificationsWebSystem.ModuleService;
using QualificationsWebSystem.ProgramService;
using QualificationsWebSystem.ModuleAsignationService;
using AcademicsServicesDIPP;
using System.Data.Linq.SqlClient;
using System.Data.Entity;
using System.Data.SqlClient;

namespace QualificationsWebSystem
{
    public partial class RegistrarMódulo : System.Web.UI.Page
    {
        //Creando canales para consumir servicios
        ModuleAdminServiceClient proxyModule = null;
        AcademicServiceClient proxyProgram = null;
        ModuleAsigAdminServiceClient proxyAsignation = null;

        //Entidades de Negocio
        Module entity = null;
        Module updateEntity = null;
        Pensum pensum = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if ((string)Session["value"] == "false")
            //{
                int count = 0;

                proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
                proxyModule = new ModuleAdminServiceClient("WSHttpBinding_IModuleAdminService");
                proxyAsignation = new ModuleAsigAdminServiceClient("WSHttpBinding_IModuleAsigAdminService");

                if (!IsPostBack)
                {
                    using (var context = new QualificationsDBEntities())
                    {
                        //QualificationsDBEntities context = new QualificationsDBEntities();
                        var program = from p in context.GraduateProgram
                                      orderby p.ProgramName.Substring(0, 1) ascending
                                      select p;

                        foreach (var query in program)
                        {
                            //Añadiendo al DropDownList con los nombres de los Programas de Postgrado
                            ddl_Programas.Items.Insert(count, query.ProgramName);
                            count = count + 1;
                        }
                        //Session["value"] = "true"; //inicializado en el WebForm Authentication
                    }
                }
            //}
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

                    updateEntity = new Module();
                    pensum = new Pensum();

                    try
                    {
                        entity = new Module();
                        entity.ModuleName = txt_ModuleName.Text;
                        entity.Mode = rbl_Mode.SelectedValue.ToString();
                        entity.Status = 2;

                        proxyModule.InsertModule(entity);

                        // Obteniendo el ID del Modulo recien añadido
                        ModuloID = proxyModule.GetModuleID(txt_ModuleName.Text);
                        //Obteniendo el ID del Programa Seleccionado
                        ProgramaID = proxyProgram.GetProgramID(nombrePrograma);
                        //Obteniendo el Modulo recien añadido
                        updateEntity = Get(ModuloID);

                        //Registrando en la Tabla Pensum
                        pensum.GraduateProgram = ProgramaID;
                        pensum.ModuleCode = ModuloID;
                        proxyAsignation.InsertAsignation(pensum);

                        //Actualizando el Módulo Añadido
                        updateEntity.Status = 1;
                        UpdateModule(updateEntity);

                        lbl_mensaje.Text = "Módulo Registrado Exitosamente";
                        txt_ModuleName.Text = "";
                    }
                    catch (Exception ex)
                    {
                        lbl_mensaje.Text = "Ocurrio un problema inesperado. El Módulo no se ha registrado";
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