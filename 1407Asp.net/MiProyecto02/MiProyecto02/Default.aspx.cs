using System;
using System.Collections.Generic;
using System.IO;    //CREO ESTE System.IO para que me acepte el File.write
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiProyecto02
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // IsPostBack = interaccion del usuario
            if (IsPostBack== false)
            {
                // esto es lo que aparece cuando cargamos la pagina
                txtNombre.Text = "ingrese su nombre";
                txtApellido.Text = "ingrese su apellido";
                txtMail.Text = "ingrese su mail";
            }
             
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            // esto  es lo que se ejecuta cuando se hace click en guardar
            string misDatos = $"Nombre:{txtNombre.Text}, Apellido: {txtApellido.Text}, Mail: {txtMail.Text}{Environment.NewLine}";
            // se crea un archivo para que escriba los datos
            //File.WriteAllText("C:\\registros.txt", misDatos);

            File.AppendAllText("C:\\Users\\lau\\Documents\\IISExpress\\documentos.txt", misDatos);
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtMail.Text = "";

            lblMensaje.Text = "Los Datos han sido guardados exitosamente";

        }
    }
}