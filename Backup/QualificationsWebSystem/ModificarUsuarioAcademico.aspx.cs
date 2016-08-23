using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QualificationsWebSystem.UserAccountAdminService;
using AcademicsServicesDIPP;

namespace QualificationsWebSystem
{
    public partial class ModificarUsuarioAcadémico : System.Web.UI.Page
    {
        UserAccountAdminServiceClient proxyUser = null;
        Person updateEntity = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            updateEntity = new Person();
            proxyUser = new UserAccountAdminServiceClient("WSHttpBinding_IUserAccountAdminService");

            long ci = long.Parse(Request.Params["IdentityCard"].ToString());
            string nombre = Request.Params["Name"].ToString();
            string paterno = Request.Params["FirstName"].ToString();
            string materno = Request.Params["LastName"].ToString();

            long userID = proxyUser.GetPerson(ci, nombre, paterno, materno);
            updateEntity = GetPerson(userID);

            if (!IsPostBack)
            {
                txt_Nombre.Text = updateEntity.Name;
                txt_APaterno.Text = updateEntity.FirstName;
                txt_AMaterno.Text = updateEntity.LastName;
                txt_CI.Text = updateEntity.IdentityCard.ToString();
                txt_Profesion.Text = updateEntity.Profession;
                txt_Email.Text = updateEntity.Email;
                txt_Celular.Text = updateEntity.MobilePhone.ToString();
                txt_Fono.Text = updateEntity.HomePhone.ToString();
                txt_Domicilio.Text = updateEntity.HomeAddress;
                txt_CPostal.Text = updateEntity.PostalCode.ToString();
            }
        }

        public Person GetPerson(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.Person.FirstOrDefault(x => x.PersonId == id);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                updateEntity.Name = txt_Nombre.Text;
                updateEntity.FirstName = txt_APaterno.Text;
                updateEntity.LastName = txt_AMaterno.Text;
                updateEntity.IdentityCard = int.Parse(txt_CI.Text);
                updateEntity.Email = txt_Email.Text;
                updateEntity.Sex = ddl_Sexo.SelectedItem.ToString();
                updateEntity.MobilePhone = int.Parse(txt_Celular.Text);
                updateEntity.HomePhone = int.Parse(txt_Fono.Text);
                updateEntity.Profession = txt_Profesion.Text;
                updateEntity.HomeAddress = txt_Domicilio.Text;
                updateEntity.City = ddl_Departamento.SelectedItem.Value.ToString();
                if (txt_CPostal.Text == "")
                {
                    updateEntity.PostalCode = null;
                }
                else
                {
                    updateEntity.PostalCode = int.Parse(txt_CPostal.Text);
                }
                updateEntity.VersionDate = DateTime.Now;

                Update(updateEntity);
                lbl_error.Text = "ÉXITO. Las modificaciones de guardaron en la Base de Datos.";
            }
            catch(Exception ex)
            {
                lbl_error.Text = "ERROR. Las modificaciones no se guardaron en la Base de Datos.";
            }
        }

        public void Update(Person entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.Person.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
                context.SaveChanges();
            }
        }
    }
}