using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MiPaginaPresentacion.clases; // creo esto para que se pueda utiliza y unir con el comentario.cs

namespace MiPaginaPresentacion.MasInformacion
{
    public partial class QuienSoy : System.Web.UI.Page
    {
        private List<Comentario> comentarios; //para que acepte esto debo añadir el using MiPaginaPresentacion.clases;
        public QuienSoy()// escribo "ctor" --> TAB -->TAB; para crear el contructor y escribir mi lista
        {
            // por la lista solo puedo agregar objetos del tipo comentario 
        }

        protected void Page_Load(object sender, EventArgs e)
        {//el ViewState sirve para manterner los comentarios y no reemplazarlos con uno nuevo
         //mientras me mantengo en la misma pagina unicamente   
            if (ViewState["comentarios"]== null/*nulo*/)
            {
                comentarios = new List<Comentario>();
                ViewState["comentarios"] = comentarios;
            }
            else 
            {
                comentarios = (List<Comentario>)ViewState["comentarios"];
            }
            lstComentarios.DataSource = comentarios;// para que lea la lista de origen
            lstComentarios.DataBind(); // para que lo publique en el html
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {// esto es para que cuando se presione el boton enviar se almacene en estas variables
            string nombre = txtNombre.Text;
            string comentario = txtComentarios.Text;

            //para que lo que escriba luego se pueda agregar a la lista de comentarios 
            Comentario nuevocomentario = new Comentario()
            {
                Nombre = nombre,
                Texto = comentario
            };
            // con esto lo agrego a la lista  de comentarios que esta arriba
            comentarios.Add(nuevocomentario);
            // esto es para vaciar los cuadros
            txtNombre.Text = "";
            txtComentarios.Text = "";

            //para imprimir en html
            lstComentarios.DataBind();
        }
    }
}