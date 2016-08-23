using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicsServicesDIPP;
using QualificationsWebSystem.OpeningService;
using QualificationsWebSystem.ProgramService;

namespace QualificationsWebSystem
{
    public partial class ModificarApertura : System.Web.UI.Page
    {
        OpeningProgramAdminServiceClient proxyOpening = null;
        AcademicServiceClient proxyProgram = null;

        OpeningProgram updateOpening = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            updateOpening = new OpeningProgram();
            proxyOpening = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");
            string programVersion = Request.Params["ProgramVersion"].ToString();
            int versionID = VersionID(programVersion);

            long programID = proxyProgram.GetProgramID(Request.Params["ProgramName"].ToString());

            long openingID = proxyOpening.GetOpeningID(programID, versionID);

            updateOpening = GetOpening(openingID);
        }

        public int VersionID(string version)
        {
            int versionID = 0;
            using (var context = new QualificationsDBEntities())
            {
                var id = from v in context.Version
                        where v.ProgramVersion == version
                        select new
                        {
                            version = v.ID
                        };

                foreach (var query in id)
                {
                    versionID = query.version;
                }
            }

            return versionID;
        }

        public OpeningProgram GetOpening(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.OpeningProgram.FirstOrDefault(x => x.OpeningCode == id);
            }
        }

        public int VersionValue(int index)
        {
            return index + 1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string programa = ddl_Programas.SelectedValue;
            try
            {
                int firstGestion = Calendar1.SelectedDate.Year;
                int lastGestion = Calendar2.SelectedDate.Year;
                string gestion = firstGestion + " - " + lastGestion;

                updateOpening.ProgramId = proxyProgram.GetProgramID(programa);
                updateOpening.StartDate = Calendar1.SelectedDate;
                updateOpening.EndDate = Calendar2.SelectedDate;
                updateOpening.Version = VersionValue(ddl_Version.SelectedIndex);
                updateOpening.Gestion = gestion;
                updateOpening.Status = 1;

                Update(updateOpening);
                lbl_Mensaje.Text = "ÉXITO. Las modificaciones se han guardado en la Base de Datos.";
            }
            catch (Exception ex)
            {
                lbl_Mensaje.Text = "ERROR. Las modificaciones no se han guardado en la Base de Datos.";
            }
        }

        public void Update(OpeningProgram entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.OpeningProgram.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
                context.SaveChanges();
            }
        }
    }
}