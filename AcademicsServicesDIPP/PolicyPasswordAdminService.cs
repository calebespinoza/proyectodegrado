using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AcademicsServicesDIPP
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "politicsPasswordAdminService" in both code and config file together.
    public class PolicyPasswordAdminService : IPolicyPasswordAdminService
    {
        string expresionRegular1 = string.Empty;
        string expresionRegular2 = string.Empty;
        string expresionRegular3 = string.Empty;

        public void InsertPolicyPassw0rd(PasswordPolicy enitity)
        {
            
        }


        public string GetPolicyPassword()
        {
            QualificationsDBEntities contex = new QualificationsDBEntities();
            string exReg = string.Empty;
            string conc = string.Empty;

            var politicaNro = from pc in contex.PasswordPolicy
                              where pc.PasswordPolicyCode == "Nro"
                              select new { pc.Status, pc.RegularExpression };
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
                              select new { pMin.Status, pMin.RegularExpression };
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

            return conc = @expresionRegular1 + expresionRegular2 + expresionRegular3 + exReg;
        }
    }
}
