using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiProyecto01
{
    //siempre al crear el archivo index que sea un nombre de clase con mayunscula al inicio por ejemplo
    // MiSitio
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // esto es lo que se ejecuta cuando en index.aspx llamo un elemento del servidor
            lblSaludo.Text = "Hola mundo";
            lblConfidencial.Visible = false;
        }
        // esto se ejecuta por esto <asp:Button runat="server" ID="btnSaludar" Text="Saludar" OnClick="btnSaludar_Click"/>

        protected void btnSaludar_Click(object sender, EventArgs e)
        {
            lblSaludarPersona.Text = "Hola " + txtNombre.Text;
        }
    }
}