using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicsServicesDIPP;
using QualificationsWebSystem.TeacherModuleService;
using QualificationsWebSystem.ModuleService;
using QualificationsWebSystem.ProgramService;
using QualificationsWebSystem.OpeningService;
using QualificationsWebSystem.GlobalPlanService;

namespace QualificationsWebSystem
{
    public partial class RegistrarAvanceContenido : System.Web.UI.Page
    {
        string modulo = string.Empty;
        string gestion = string.Empty;
        string docente = string.Empty;

        string nombreModulo = string.Empty;
        string nombrePrograma = string.Empty;
        string version = string.Empty;
        //long globalPlanId = 0;

        TeacherModuleAdminServiceClient proxyTM = null;
        ModuleAdminServiceClient proxyModule = null;
        OpeningProgramAdminServiceClient proxyOP = null;
        GlobalPlanAdminServiceClient proxyGP = null;
        AcademicServiceClient proxyProgram = null;

        string tema = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxyTM = new TeacherModuleAdminServiceClient("WSHttpBinding_ITeacherModuleAdminService");
            proxyModule = new ModuleAdminServiceClient("WSHttpBinding_IModuleAdminService");
            proxyOP = new OpeningProgramAdminServiceClient("WSHttpBinding_IOpeningProgramAdminService");
            proxyGP = new GlobalPlanAdminServiceClient("WSHttpBinding_IGlobalPlanAdminService");
            proxyProgram = new AcademicServiceClient("WSHttpBinding_IAcademicService");

            nombreModulo = Request.Params["ModuleName"].ToString();
            nombrePrograma = Request.Params["ProgramName"].ToString();
            version = Request.Params["ID"].ToString();

            long programaId = proxyProgram.GetProgramID(nombrePrograma);
            int versionId = GetVersion(version);
            long aperturaId = proxyOP.GetOpeningID(programaId, versionId);
            long moduleId = proxyModule.GetModuleID(nombreModulo);
            long teachModuleId = proxyTM.GetTeacherModule(moduleId, aperturaId);
            long globalPlanId = proxyGP.GetGlobalPlan(teachModuleId);
            Session["GlobalPlanID"] = globalPlanId;

            Temas(globalPlanId);
        }

        public int GetVersion(string description)
        {
            int ID = 0;
            using (var context = new QualificationsDBEntities())
            {
                var version = from v in context.Version
                              where v.ProgramVersion == description
                              select v;
                foreach (var query in version)
                {
                    ID = query.ID;
                }
            }
            return ID;
        }

        public void Temas(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                var themes = from t in context.ContentThematic
                             join st in context.StatusThemeContent
                             on t.Code equals st.ContentCode
                             where t.GlobalPlan == id && st.StatusThemeCode == 0
                             select new
                             {
                                 Tema = t.Theme
                             };
                GridView1.DataSource = themes;
                GridView1.DataBind();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_tema.Text = "TEMA SELECCIONADO: "+this.GridView1.SelectedRow.Cells[1].Text;
        }

        public long ContentID(long globalplanId, string theme)
        {
            long id = 0;
            using(var context = new QualificationsDBEntities())
            {
                var query = from q in context.ContentThematic
                            where q.GlobalPlan == globalplanId && q.Theme == theme
                            select q;
                foreach (var ct in query)
                {
                    id = ct.Code;
                }
            }
            return id;
        }

        public long EstadoID(long contentId)
        {
            long id = 0;
            using (var context = new QualificationsDBEntities())
            {
                var query = from q in context.StatusThemeContent
                            where q.ContentCode == contentId && q.StatusThemeCode == 0
                            select q;
                foreach (var st in query)
                {
                    id = st.StatusThemeContent1;
                }
            }
            return id;
        }

        public StatusThemeContent Entidad(long EstadoID)
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.StatusThemeContent.FirstOrDefault(x => x.StatusThemeContent1 == EstadoID);
            }
        }

        public void UpdateTema(StatusThemeContent entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.StatusThemeContent.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
                context.SaveChanges();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StatusThemeContent estado = new StatusThemeContent();
            tema = this.GridView1.SelectedRow.Cells[1].Text; ;
            long contentID = ContentID((long)Session["GlobalPlanID"], tema);
            long statusID = EstadoID(contentID);
            estado = Entidad(statusID);

            try
            {
                estado.StatusThemeCode = 1;
                estado.Date = DateTime.Today;
                UpdateTema(estado);

                lbl_tema.Text = "ÉXITO. Se ha registrado el avance del Tema: "+tema;
                Temas((long)Session["GlobalPlanID"]);
            }
            catch
            {
                lbl_tema.Text = "ERROR. Los datos NO se han guardado";
            }

        }

    }
}