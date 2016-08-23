using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QualificationsWebSystem.UserAccountAdminService;
using AcademicsServicesDIPP;
using System.Data.Linq.SqlClient;
using System.Data.Entity;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Web.DataAccess;
using System.Text.RegularExpressions;


namespace QualificationsWebSystem
{
    public partial class RegistrarUsuario : System.Web.UI.Page
    {
        UserAccountAdminServiceClient proxy = null;
        Person persona = null;
        UserAccount userAccount = null;
        UserRole userRole = null;
        SqlDataReader lector;
        long personID;
        string expresionRegular1 = string.Empty;
        string expresionRegular2 = string.Empty;
        string expresionRegular3 = string.Empty;

        string exReg = string.Empty;//".{6,15}$";
        string conc = string.Empty;

        
        


        protected void Page_Load(object sender, EventArgs e)
        {
            proxy = new UserAccountAdminServiceClient("WSHttpBinding_IUserAccountAdminService");
            personID = 0;
            //SqlConnection conn = new SqlConnection("Data Source=DV41117NR\\SQLEXPRESS2008;Initial Catalog=QualificationsDB;Integrated Security=True");

            //conn.Open();
            //string com;
            //com = "select GETDATE()";
            //SqlCommand comando = new SqlCommand(com, conn);
            //lector = comando.ExecuteReader();
            //lector.Read();
            //fechaActual = lector.GetDateTime(0);
            //conn.Close();
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            persona = new Person();
            userAccount = new UserAccount();
            userRole = new UserRole();

            
            lbl_error.Text = "";

            if (txt_Pass.Text != "")
            {
                if (txt_Confirmar.Text != "")
                {
                    if (txt_Pass.Text == txt_Confirmar.Text)
                    {
                        if (VerificarConstraseña())
                        {
                            try
                            {
                                persona.Name = txt_Nombre.Text;
                                persona.FirstName = txt_APaterno.Text.Trim(); //Trim borra espacios en la cadena
                                persona.LastName = txt_AMaterno.Text;
                                persona.IdentityCard = int.Parse(txt_CI.Text);
                                persona.Email = txt_Email.Text;
                                persona.MobilePhone = int.Parse(txt_Celular.Text);
                                persona.HomePhone = int.Parse(txt_Fono.Text);
                                persona.HomeAddress = txt_Domicilio.Text;
                                persona.Sex = ddl_Sexo.SelectedItem.ToString();
                                persona.City = ddl_Departamento.SelectedItem.Value.ToString();
                                persona.Profession = txt_Profesion.Text;
                                persona.CreateDate = DateTime.Now;
                                persona.VersionDate = DateTime.Now;

                                if (txt_CPostal.Text == "")
                                {
                                    persona.PostalCode = null;
                                }
                                else
                                {
                                    persona.PostalCode = int.Parse(txt_CPostal.Text);
                                }

                                proxy.InsertPerson(persona);

                                personID = proxy.GetPerson(int.Parse(txt_CI.Text), txt_Nombre.Text, txt_APaterno.Text, txt_AMaterno.Text);
                                userAccount.UserAccountId = int.Parse(personID.ToString());
                                userAccount.Account = txt_Cuenta.Text;
                                userAccount.Password = txt_Pass.Text;
                                userAccount.AccountStatus = int.Parse(ddl_Status.SelectedItem.Value.ToString());

                                proxy.InsertUserAccount(userAccount);

                                userRole.UserAccountId = int.Parse(personID.ToString());
                                userRole.RoleCode = int.Parse(ddl_Rol.SelectedItem.Value.ToString());

                                proxy.InsertUserRole(userRole);

                                lbl_error.Text = "Usuario Registrado Exitosamente !!";
                                Herramientas.limpiar(this.Controls);
                            }
                            catch (Exception ex)
                            {
                                lbl_error.Text = "ERROR. Los datos no han sido registrados";
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
                lbl_error.Text = "Escriba su Contraseña";
            }


        }

        //public void PoliticaContraseña()
        //{
        //    if (RadioButton1.Checked)
        //    {
        //        expresionRegular1 = @"^(?=.*\d)"; 
        //    }
        //    else
        //        expresionRegular1 = "";

        //    if(RadioButton2.Checked)
        //    {
        //        expresionRegular1 = "(?=.*[a-z])";
        //    }
        //    else
        //        expresionRegular2 = "";

        //    if(RadioButton3.Checked)
        //    {
        //        expresionRegular3 = "(?=.*[A-Z])";
        //    }
        //    else
        //        expresionRegular3 = "";

        //    conc = expresionRegular1 + expresionRegular2+expresionRegular3+exReg;

        //}

        public bool VerificarConstraseña()
        {
            //PoliticaContraseña();
            DefinirPolitica();
            if (Regex.IsMatch(txt_Pass.Text.Trim(), conc))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DefinirPolitica()
        {
            QualificationsDBEntities contex = new QualificationsDBEntities();

            var politicaNro = from pc in contex.PasswordPolicy
                           where pc.PasswordPolicyCode == "Nro"
                           select new { pc.Status, pc.RegularExpression};
            foreach (var query in politicaNro)
            {
                if (query.Status == 1)
                {
                    expresionRegular1 = query.RegularExpression;
                }
                else
                {
                    expresionRegular1 = "";
                }
            }

            var politicaMin = from pMin in contex.PasswordPolicy
                              where pMin.PasswordPolicyCode == "Min"
                              select new { pMin.Status, pMin.RegularExpression};
            foreach (var query in politicaMin)
            {
                if (query.Status == 1)
                {
                    expresionRegular2 = query.RegularExpression;
                }
                else
                {
                    expresionRegular2 = "";
                }
            }

            var politicaMay = from pMay in contex.PasswordPolicy
                              where pMay.PasswordPolicyCode == "May"
                              select new { pMay.Status, pMay.RegularExpression };
            foreach (var query in politicaMay)
            {
                if (query.Status == 1)
                {
                    expresionRegular3 = query.RegularExpression;
                }
                else
                {
                    expresionRegular3 = "";
                }
            }

            var politicaTam = from pTam in contex.PasswordPolicy
                              where pTam.PasswordPolicyCode == "Tam"
                              select new { pTam.RegularExpression };
            foreach (var query in politicaTam)
            {
                 exReg = query.RegularExpression;
            }

            conc = @expresionRegular1 + expresionRegular2 + expresionRegular3 + exReg;
        }

    }
}