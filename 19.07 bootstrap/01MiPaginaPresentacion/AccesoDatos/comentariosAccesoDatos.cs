using Entidades;
using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class comentariosAccesoDatos //colocar como publica para que pueda trabajar con otros proyectos
    {
        //ESTO ES SIN CONECTAR A BD
        //public List<Comentario> comentarios;

        //CON BD
        private string cadena = ConfigurationManager.ConnectionStrings["PaginaPresentacionDB"].ConnectionString;


        public comentariosAccesoDatos()// agrego un contructor con "ctor" para poder despues agregar y devolver comentarios
        {
            //comentarios = new List<Comentario>();
        }

        public bool AgregarComentario(Comentario comentario) //insertar los comentarios en la base de datos
        {
            string consulta = $@"INSERT INTO Comentarios(Nombre,Texto)
                                VALUES('{comentario.Nombre}','{comentario.Texto}')";

            int resultado;
            //CON EL USING EVITO ESTAR CERRANDO CADA CONEXION Y LO HACE MAS OPTIMO
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();
                    //esto nos devolvera cuantos registros fueron afectados
                    resultado = comando.ExecuteNonQuery();//significa que no es una consulta ya que "insertar" no lo es

                }
            }


            if (resultado == 1)//para verificar que se haya ingresado en la BD
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Comentario> ObtenerComentarios() // retorno los comentarios enviados
        {
            List<Comentario> resultado = new List<Comentario>();

            //PARA TRAER LOS COMENTARIOS DE LA BD
            string consulta = "SELECT Id,Nombre,Texto FROM Comentarios";//si la consulta es muy grande puedo
            //colocar un "@" al principio

            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    try
                    {
                        conexion.Open();//abrir conexion
                        SqlDataReader reader = comando.ExecuteReader();//accion para leer y ejecutar la tabla

                        while (reader.Read()) //despues de seleccionar alguna, pasa a la siguiente
                        {
                            Comentario comentario = new Comentario()
                            {
                                Id = reader.GetInt32(0),
                                //indica los datos a leer
                                Nombre = reader.GetString(1),
                                //otra forma de llamar
                                Texto = reader["Texto"].ToString()//le coloco el Tostring() porque sino lo toma como objet
                            };
                            resultado.Add(comentario);//se añade a la lista de comentarios
                        }
                        //reader.Close();//siempre cerrar el reader
                        //conexion.Close();//cerrar conexion
                    }
                    catch (SqlException ex)
                    {
                        throw new CapaDeDatosException();//con throw hago el intercambio entre SqlException y CapaDeDatosException 
                    }


                }
            }
            ;


            return resultado;
        }
        public bool BorrarComentario(int id)
        {
            string consulta = $@"DELETE FROM Comentarios
                                WHERE Id={id}";

            int resultado;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                resultado = comando.ExecuteNonQuery();
            }
            if (resultado == 1)//para verificar que se haya ingresado en la BD
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ModificarComentario(Comentario comentario)
        {
            string consulta = $@"UPDATE Comentarios 
                                SET Nombre='{comentario.Nombre}','{comentario.Texto}',
                                WHERE Id={comentario.Id}";

            int resultado;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();
                resultado = comando.ExecuteNonQuery();
            }
            if (resultado == 1)//para verificar que se haya ingresado en la BD
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // agregarle una pagina nueva en donde muestre la actualizacion que se hizo
        public Comentario ObtenerComentarios(int id) // 
        {
            Comentario resultado = null;


            string consulta = $@"SELECT Id,Nombre,Texto FROM Comentarios
                               WHERE ID={id}";


            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read()) //quito el while y pongo el "if" ya que la condicion es si encuentra 
                                       //un resultado modificar solo ese
                    {
                        resultado = new Comentario()
                        {
                            Id = reader.GetInt32(0),

                            Nombre = reader.GetString(1),

                            Texto = reader["Texto"].ToString()
                        };

                    }
                }
            }
            ;


            return resultado;
        }
    }
}
