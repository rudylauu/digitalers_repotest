using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiPaginaPresentacion.MasInformacion
{
    public partial class BorrarComentario : System.Web.UI.Page
    {
        ComentarioNegocio comentarioNegocio = new ComentarioNegocio();//para usar la clase ComentarioNegocio.cs
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"]; //Request es para pedir los datos 
            if (string.IsNullOrWhiteSpace(id))
            {
                pnlError.Visible = true;
            }
            else
            {
                //borrar
                int IdEntero = Convert.ToInt32(id);
                bool resultado = comentarioNegocio.BorrarComentario(IdEntero);
                if(resultado == true)
                {
                    Response.Redirect("~/MasInformacion/QuienSoy.aspx");//para que redirija a la pagina
                }
                else
                {
                    pnlError.Visible = true; //si no puede borrar mostrara el panel rojo
                }
            }
        }
    }
}