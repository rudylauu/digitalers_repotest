using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPaginaPresentacion.MasterPages
{
    public partial class Sitio : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                //recordar de agregar el Using System.Configuration
                //con esto cambia al cambiar el nombre en Web.Config se cambiara automaticamente
                /* tambien se puede condicionar a que si en Web.Config no hay nada coloque lo que esta despues de "??"
                  lblNombrePersona.Text = ConfigurationManager.AppSettings["NombrePersona"] ?? "(colocar nombre)"*/
                lblNombrePersona.Text = ConfigurationManager.AppSettings["NombrePersona"];           }
        }
    }
}