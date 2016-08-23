using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace QualificationsWebSystem
{
    public static class Herramientas
    {
        public static void limpiar(ControlCollection ventana)
        {
            foreach(Control c in ventana)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

    }
}