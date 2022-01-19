using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;// lo agrego despues de crear la referencia
using Entidades.Exceptions;
using Negocio;

namespace MiPaginaPresentacion.MasInformacion
{
    public partial class QuienSoy : System.Web.UI.Page
    {
        private static ComentarioNegocio comentarioNegocio = new ComentarioNegocio();
        public QuienSoy()// escribo "ctor" --> TAB -->TAB; para crear el contructor y escribir mi lista
        {
            // por la lista solo puedo agregar objetos del tipo comentario 
        }

        protected void Page_Load(object sender, EventArgs e)
        {//el ViewState sirve para manterner los comentarios y no reemplazarlos con uno nuevo
         //mientras me mantengo en la misma pagina unicamente
         //
         //ESTO NO ES NECESARIO YA QUE LO REMPLAZO POR LAS CLASES DE ARQUITECTURA EN CAPAS
         //if (ViewState["comentarios"]== null/*nulo*/)
         //{
         //    comentarios = new List<Comentario>();
         //    ViewState["comentarios"] = comentarios;
         //}
         //else 
         //{
         //    comentarios = (List<Comentario>)ViewState["comentarios"];
         //
         //

            //EXCEPCIONES Y TRATAMIENTO DE ERRORES
            
            try //intentar correr esto si falla pasa al "catch" que es el que muertra los errores
            {
                lstComentarios.DataSource = comentarioNegocio.ObtenerComentarios();//para que lea la lista de origen
                lstComentarios.DataBind(); // para que lo publique en el html
            } 
            catch (CapaDeDatosException ex)//exception es una clase Padre ´por ende atrapa todos los errores
            {
                lblError.Text = "Ocurrio un error al solicitar los comentarios. Porfavor intente mas tarde.";
                pnlError.Visible = true; 
            }
            
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
            bool resultado = comentarioNegocio.GuardarComentarios(nuevocomentario);
            // esto es para vaciar los cuadros
            txtNombre.Text = "";
            txtComentarios.Text = "";

            //para imprimir en html
            lstComentarios.DataSource = comentarioNegocio.ObtenerComentarios();//para que lea la lista de origen
            lstComentarios.DataBind(); // para que lo publique en el html
        }
    }
}