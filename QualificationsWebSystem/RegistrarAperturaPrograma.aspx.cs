using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Linq.SqlClient;
using AcademicsServicesDIPP;
using QualificationsWebSystem.OpeningService;
using QualificationsWebSystem.ProgramService;

namespace QualificationsWebSystem
{
    public partial class RegistrarAperturaPrograma : System.Web.UI.Page
    {
        OpeningProgramAdminServiceClient proxyOpening = null;
        AcademicServiceClient proxyProgram = null;

        OpeningProgram opening = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxyOpening = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
        }

        public int VersionValue(int index)
        {
            return index + 1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            opening = new OpeningProgram();
            string gestion = string.Empty;
            
            string programa = ddl_Programas.SelectedValue;

            try
            {
                long ID = proxyProgram.GetProgramID(programa);
                DateTime start = Calendar1.SelectedDate;
                DateTime end = Calendar2.SelectedDate;

                int firstGestion = Calendar1.SelectedDate.Year;
                int lastGestion = Calendar2.SelectedDate.Year;
                gestion = firstGestion + " - " + lastGestion;

                opening.ProgramId = ID;
                opening.StartDate = start;
                opening.EndDate = end;
                opening.Version = VersionValue(ddl_Version.SelectedIndex);
                opening.Gestion = gestion;
                opening.Status = 1;

                proxyOpening.InsertOpening(opening);
                lbl_Mensaje.Text = "El Programa -" + ddl_Programas.SelectedValue + "- ha sido Abierto con éxito !";
            }
            catch (Exception ex)
            {
                lbl_Mensaje.Text = "ERROR. No se han guardado los datos !";
            }
        }
    }
}