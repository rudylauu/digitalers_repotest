using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPaginaPresentacion.MasInformacion.Ocupacion
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)//o (!IsPostBack)  solo cuando carga por primera vez la pagina
            
                /*esto es para que cuando cargue la pagina automaticamente me muestre en cuanto quedo el conteo
            de lo contrario aparecera en "0" y cuando le de click aparecera donde me quede*/
            if (Session["contador"] != null)
            {
                lblContadorSession.Text = Session["contador"].ToString();
            }
            
            //para preguntar si existe
            if(Request.Cookies["contador"] != null)
            {
                lblContadorCookies.Text = Request.Cookies["contador"].Value;
            }
        }

        protected void btnContarViewState_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (ViewState["contador"] != null )
            {
                // el (int) indica que el ViewState tendra enteros
                contador = (int)ViewState["contador"];
            }
            //coloco el incremento
            contador++;
            //esto se coloca de ultimo para que le devuelva al cliente el contador actualizado
            ViewState["contador"] = contador;
            // actualizar el label/// ToString es para que lo convierta en un Texto y el Label lo lea
            lblContadorViewState.Text = contador.ToString();
        }

        protected void btnContarSession_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (Session["contador"] != null)
            {
                contador = (int)Session["contador"];
            }
            contador++;
            Session["contador"] = contador;
            lblContadorSession.Text = contador.ToString();
        }

        protected void btnContarCookies_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if(Request.Cookies["contador"] != null) 
            {
                // (Request.Cookies["contador"].Value) -->las cookies siempre son String por eso uso
                //Convert.ToInt32 para convertir a entero
                contador = Convert.ToInt32(Request.Cookies["contador"].Value);
            }
            contador++;
            Response.Cookies["contador"].Value = contador.ToString();
            //esto es para ponerle tiempo a las Cookies
            Response.Cookies["contador"].Expires = DateTime.Now.AddMinutes(1);
            lblContadorCookies.Text = contador.ToString();


        }
    }
}