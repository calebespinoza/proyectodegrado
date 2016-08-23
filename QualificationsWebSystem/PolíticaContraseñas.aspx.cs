using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AcademicsServicesDIPP;
using QualificationsWebSystem.PolicyPasswordService;

namespace QualificationsWebSystem
{
    public partial class PolíticaContraseñas : System.Web.UI.Page
    {
        string minusculas = string.Empty;
        string mayusculas = string.Empty;
        string numeros = string.Empty;

        string expresionRegular1 = string.Empty;
        string expresionRegular2 = string.Empty;
        string expresionRegular3 = string.Empty;
        string nros = string.Empty;

        PolicyPasswordAdminServiceClient proxyPolicy = null;

        PasswordPolicy Mayuscula = null;
        PasswordPolicy Minuscula = null;
        PasswordPolicy Numeros = null;
        PasswordPolicy Tamaño = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            proxyPolicy = new PolicyPasswordAdminServiceClient("WSHttpBinding_IPolicyPasswordAdminService");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rbl_Minusculas.Enabled)
            {
                if (rbl_Minusculas.SelectedItem.Text == "Habilitar")
                {
                    expresionRegular1 = "^(?=.*[a-z])";

                    try
                    {
                        Minuscula = new PasswordPolicy();

                        Minuscula = GetMinusculas();
                        Minuscula.Status = 1;
                        Minuscula.RegularExpression = expresionRegular1;

                        UpdatePolicy(Minuscula);
                    }
                    catch(Exception ex)
                    {
                        lbl_Mensaje.Text = "ERROR. No se çonfiguró la política para caracteres en minúsculas";
                    }
                    
                }

                if (rbl_Minusculas.SelectedItem.Text == "Deshabilitar")
                {
                    expresionRegular1 = "";
                    try
                    {
                        Minuscula = new PasswordPolicy();

                        Minuscula = GetMinusculas();
                        Minuscula.Status = 0;
                        Minuscula.RegularExpression = expresionRegular1;
                        UpdatePolicy(Minuscula);
                    }
                    catch(Exception ex)
                    {
                        lbl_Mensaje.Text = "ERROR. No se çonfiguró la política para caracteres en minúsculas";
                    }
                    
                }
            }

            if (rbl_Mayusculas.Enabled)
            {
                if (rbl_Mayusculas.SelectedItem.Text == "Habilitar")
                {
                    expresionRegular2 = "(?=.*[A-Z])";
                    try
                    {
                        Mayuscula = new PasswordPolicy();

                        Mayuscula = GetMayusculas();
                        Mayuscula.Status = 1;
                        Mayuscula.RegularExpression = expresionRegular2;
                        UpdatePolicy(Mayuscula);
                    }
                    catch (Exception ex)
                    {
                        lbl_Mensaje.Text = "ERROR. No se çonfiguró la política para caracteres en mayúsculas";
                    }
                }
                if (rbl_Mayusculas.SelectedItem.Text == "Deshabilitar")
                {
                    expresionRegular2 = "";
                    try
                    {
                        Mayuscula = new PasswordPolicy();

                        Mayuscula = GetMayusculas();
                        Mayuscula.Status = 0;
                        Mayuscula.RegularExpression = expresionRegular2;
                        UpdatePolicy(Mayuscula);
                    }
                    catch (Exception ex)
                    {
                        lbl_Mensaje.Text = "ERROR. No se çonfiguró la política para caracteres en minúsculas";
                    }
                }
            }

            if (rbl_Numeros.Enabled)
            {
                if (rbl_Numeros.SelectedItem.Text == "Habilitar")
                {
                    expresionRegular3 = @"(?=.*\d)";

                    try
                    {
                        Numeros = new PasswordPolicy();

                        Numeros = GetNumeros();
                        Numeros.Status = 1;
                        Numeros.RegularExpression = expresionRegular3;
                        UpdatePolicy(Numeros);
                    }
                    catch (Exception ex)
                    {
                        lbl_Mensaje.Text = "ERROR. No se çonfiguró la política para caracteres numerales";
                    }

                }
                if (rbl_Numeros.SelectedItem.Text == "Deshabilitar")
                {
                    expresionRegular3 = "";
                    try
                    {
                        Numeros = new PasswordPolicy();

                        Numeros = GetNumeros();
                        Numeros.Status = 0;
                        Numeros.RegularExpression = expresionRegular3;
                        UpdatePolicy(Numeros);
                    }
                    catch (Exception ex)
                    {
                        lbl_Mensaje.Text = "ERROR. No se çonfiguró la política para caracteres numerales";
                    }
                }
            }

            if (txt_maximo.Text != "" && txt_minimo.Text != "")
            {
                nros = ".{"+txt_minimo.Text+","+txt_maximo.Text+"}$";
                try
                {
                    Tamaño = new PasswordPolicy();

                    Tamaño = GetTamaño();

                    Tamaño.Status = 1;
                    Tamaño.RegularExpression = nros;
                    UpdatePolicy(Tamaño);
                }
                catch(Exception ex)
                {
                    lbl_Mensaje.Text = "ERROR. No se çonfiguró la política para la longitud de la Contraseña";
                }
            }

            
            //string value = Concatenar();
        }

        public PasswordPolicy GetMayusculas()
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.PasswordPolicy.FirstOrDefault(x => x.PasswordPolicyCode == "May");
            }
        }

        public PasswordPolicy GetMinusculas()
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.PasswordPolicy.FirstOrDefault(x => x.PasswordPolicyCode == "Min");
            }
        }

        public PasswordPolicy GetNumeros()
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.PasswordPolicy.FirstOrDefault(x => x.PasswordPolicyCode == "Nro");
            }
        }

        public PasswordPolicy GetTamaño()
        {
            using (var context = new QualificationsDBEntities())
            {
                return context.PasswordPolicy.FirstOrDefault(x => x.PasswordPolicyCode == "Tam");
            }
        }

        public void UpdatePolicy(PasswordPolicy entity)
        {
            using (var context = new QualificationsDBEntities())
            {
                context.PasswordPolicy.Attach(entity);
                context.ObjectStateManager.ChangeObjectState(entity, System.Data.EntityState.Modified);
                context.SaveChanges();
            }
        }
    }
}