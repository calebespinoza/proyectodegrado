using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using AcademicsServicesDIPP;
using QualificationsWebSystem.AuthenticationService;
using QualificationsWebSystem.PolicyPasswordService;
using System.Text.RegularExpressions;

namespace QualificationsWebSystem
{
    public partial class ModificarUsuario : System.Web.UI.Page
    {
        AuthenticationServiceClient proxyAuth = null;
        PolicyPasswordAdminServiceClient proxyPolicy = null;

        Person updateEntity = null;
        UserAccount updateUser = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            updateEntity = new Person();
            updateUser = new UserAccount();
            proxyAuth = new AuthenticationServiceClient("WSHttpBinding_IAuthenticationService");
            proxyPolicy = new PolicyPasswordAdminServiceClient("WSHttpBinding_IPolicyPasswordAdminService");

            string cuenta = Request.Params["Account"].ToString();
            string pass = Request.Params["Password"].ToString();

            long userID = proxyAuth.GetID(cuenta, pass);
            updateEntity = GetPerson(userID);
            updateUser = GetUser(userID);

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
                txt_Pass.Text = updateUser.Password;
            }
        }

        public Person GetPerson(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.Person.FirstOrDefault(x => x.PersonId == id);
            }
        }

        public UserAccount GetUser(long id)
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.UserAccount.FirstOrDefault(x => x.UserAccountId == id);
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

        public void UpdateUser(UserAccount entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.UserAccount.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
                context.SaveChanges();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txt_Pass.Text != "")
            {
                if (txt_Confirmar.Text != "")
                {
                    if (txt_Pass.Text == txt_Confirmar.Text)
                    {
                        if (VerificarConstraseña())
                        {
                            string nombre = txt_Nombre.Text;
                            string paterno = txt_APaterno.Text;
                            string materno = txt_AMaterno.Text;
                            long ci = long.Parse(txt_CI.Text);
                            string sexo = ddl_Sexo.SelectedItem.ToString();
                            string email = txt_Email.Text;
                            int celular = int.Parse(txt_Celular.Text);
                            int fono = int.Parse(txt_Fono.Text);
                            string domicilio = txt_Domicilio.Text;
                            string ciudad = ddl_Departamento.SelectedItem.Value.ToString();
                            string profesion = txt_Profesion.Text;

                            try
                            {
                                updateEntity.Name = nombre;
                                updateEntity.FirstName = paterno;
                                updateEntity.LastName = materno;
                                updateEntity.IdentityCard = ci;
                                updateEntity.Sex = sexo;
                                updateEntity.Email = email;
                                updateEntity.MobilePhone = celular;
                                updateEntity.HomePhone = fono;
                                updateEntity.HomeAddress = domicilio;
                                updateEntity.City = ciudad;
                                updateEntity.Profession = profesion;
                                if (txt_CPostal.Text == "")
                                {
                                    updateEntity.PostalCode = null;
                                }
                                else
                                {
                                    updateEntity.PostalCode = int.Parse(txt_CPostal.Text);
                                }
                                updateEntity.VersionDate = DateTime.Now;

                                updateUser.Password = txt_Pass.Text;
                                UpdateUser(updateUser);
                                Update(updateEntity);
                                lbl_error.Text = "ÉXITO. Las modificaciones de guardaron en la Base de Datos.";
                            }
                            catch (Exception ex)
                            {
                                lbl_error.Text = "ERROR. No se guardo las modificaciones en la Base de Datos.";
                            }
                        }
                        else
                        {
                            lbl_error.Text = "Contraseña no valida";
                        }
                    }
                    else
                    {
                        lbl_error.Text = "La contraseña no coincide";
                    }
                }
                else
                {
                    lbl_error.Text = "Confirme la contraseña";
                }
            }
            else
            {
                lbl_error.Text = "Escriba la Contraseña";
            }
        }

        public bool VerificarConstraseña()
        {
            string validation = proxyPolicy.GetPolicyPassword();
            if (Regex.IsMatch(txt_Pass.Text.Trim(), validation))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}