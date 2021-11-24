using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjemploComboAutomatico
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if(IsPostBack == false)
            if (!IsPostBack) //IsPostBack: se esta publicando de nuevo?
            {
                ListItem curso0 = new ListItem("Seleccione", "0");//("texto","valor")
                lstCursos.Items.Add(curso0);
                ListItem curso1 = new ListItem("CSharp", "1");//("texto","valor")
                lstCursos.Items.Add(curso1);
                ListItem curso2 = new ListItem("NodeJs", "2");
                lstCursos.Items.Add(curso2);
                ListItem curso3 = new ListItem("Python", "3");
                lstCursos.Items.Add(curso3);
            }
        }

        protected void lstCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCursos.Text = lstCursos.SelectedValue; //para que devuelva el curso seleccionado en el label.
        }
    }
}