using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QualificationsWebSystem.ProgramService;
using AcademicsServicesDIPP;
using System.Data.Linq.SqlClient;
using System.Data.Entity;

namespace QualificationsWebSystem
{
    public partial class RegistrarProgramaPost : System.Web.UI.Page
    {
        AcademicServiceClient proxy = null;
        GraduateProgram entity = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new AcademicServiceClient("WSHttpBinding_IAcademicService");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            entity = new GraduateProgram();

            //entity.GraduateProgramaId = 100008;
            entity.ProgramName = txt_ProgramName.Text;
            entity.Type = int.Parse(TypeProgram.SelectedValue.ToString());
            entity.Objective = txt_ObjectiveProgram.Text;
            entity.Profile = txt_Profile.Text;
            entity.AdmissionRequeriments = Requerimientos();
            entity.ResgistrationCost = float.Parse(txt_Costo.Text);

            proxy.InsertProgram(entity);
        }

        public string Requerimientos()
        {
            string rq = string.Empty;

            string titulo = string.Empty;
            string cedula = string.Empty;
            string certificado = string.Empty;

            if (cbx_Titulo.Checked)
            {
                titulo = "● "+cbx_Titulo.Text+".  ";
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