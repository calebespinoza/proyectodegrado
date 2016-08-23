using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QualificationsWebSystem.ProgramService;
using AcademicsServicesDIPP;

namespace QualificationsWebSystem
{
    public partial class ModificarProgramaPostgrado : System.Web.UI.Page
    {
        AcademicServiceClient proxyProgram = null;
        GraduateProgram updateProgram = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Params["ProgramName"].ToString();
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
            updateProgram = new GraduateProgram();
            long programID = proxyProgram.GetProgramID(name);
            updateProgram = GetProgram(programID);

            if(!IsPostBack)
            {
                txt_ProgramName.Text = updateProgram.ProgramName;
                txt_ObjectiveProgram.Text = updateProgram.Objective;
                txt_Profile.Text = updateProgram.Profile;
                txt_Costo.Text = updateProgram.ResgistrationCost.ToString();
            }

        }

        public GraduateProgram GetProgram(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.GraduateProgram.FirstOrDefault(x => x.GraduateProgramaId == id);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                updateProgram.ProgramName = txt_ProgramName.Text;
                updateProgram.Type = int.Parse(TypeProgram.SelectedValue.ToString());
                updateProgram.Profile = txt_Profile.Text;
                updateProgram.AdmissionRequeriments = Requerimientos();
                updateProgram.ResgistrationCost = float.Parse(txt_Costo.Text);

                Update(updateProgram);
                lbl_mensaje.Text = "ÉXITO. Los datos se han modificado.";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Text = "ERROR. Los datos no se han modificado.";
            }
        }

        public void Update(GraduateProgram entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.GraduateProgram.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
                context.SaveChanges();
            }
        }

        public string Requerimientos()
        {
            string rq = string.Empty;

            string titulo = string.Empty;
            string cedula = string.Empty;
            string certificado = string.Empty;

            if (cbx_Titulo.Checked)
            {
                titulo = "● " + cbx_Titulo.Text + ".  ";
            }
            if (cb_Cedula.Checked)
            {
                cedula = "● " + cb_Cedula.Text + ".  ";
            }
            if (cbx_Certificado.Checked)
            {
                certificado = "● " + cbx_Certificado.Text + ".  ";
            }

            return titulo + cedula + certificado;
        }
    }
}