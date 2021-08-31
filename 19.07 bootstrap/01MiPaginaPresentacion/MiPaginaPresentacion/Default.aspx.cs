using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPaginaPresentacion
{
    public partial class Default : System.Web.UI.Page
    {
        // clases a partir de las cuales puedo crear objetos
        private List<string> proyectos;
        public Default()
        {
            /*proyectos = new List<string>();
            proyectos.Add("Página de presentacion");
            proyectos.Add("Blog");
            proyectos.Add("Sitio de noticias");*/

            proyectos = new List<string>()
            {
                "pagina de presentación",
                "Blog",
                "Sitio de noticias"
            };
        }
        // configurar la pagina de forma visual se hace en el Page_load
        protected void Page_Load(object sender, EventArgs e)
        {
            // DataSource= origen de datos= lista de proyectos
            // con esto le asigno la lista de elementos 
            lstProyectos.DataSource = proyectos;
            // darle la instruccion que publique en el html la lista
            lstProyectos.DataBind();
        }
    }
}