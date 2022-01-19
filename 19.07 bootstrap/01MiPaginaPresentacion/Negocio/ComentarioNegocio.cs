using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ComentarioNegocio// EN ESTA CAPA COLOCO TODA LA LOGICA, VALIDACION PARA QUE NADIE INSERTE UN VALOR VACIO
    {
        private comentariosAccesoDatos comentariosDatos = new comentariosAccesoDatos();

        public bool GuardarComentarios(Comentario comentario)
        {
            bool resultado = false;
            //string.IsNullOrWhiteSpace(comentario.Nombre) es igual a comentario.Nombre !=""  
            //con la dif que si escriben espacio no los deja pasar
            if (string.IsNullOrWhiteSpace(comentario.Nombre)==false && 
                string.IsNullOrWhiteSpace(comentario.Texto)==false)
            {
                resultado = comentariosDatos.AgregarComentario(comentario);
                
            }
            return resultado;
        }

        public List<Comentario> ObtenerComentarios() // de la capa de acceso a datos
        {
            return comentariosDatos.ObtenerComentarios();
        }
        public bool BorrarComentario(int id)
        {
            return comentariosDatos.BorrarComentario(id);
        }
    }
}
