using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * INFERIR TIPOS DE DATOS DEL VALOR ASIGNADO
             */
            string unTexto = "un texto";

            var otroTexto = "otro texto"; //al asignarle un texto automaticamente deduce que es un string.
            var unEntero = 10; // al asignarle un numero entero deduce que el tipo de dato es un int

            //var Numero;  si o si necesito asignarle un valor para que entienda que tipo de dato es


            /*
             * OBJETOS ANONIMOS
             */
            var miObjetoAnonimo = new //como no se de que tipo de clase es le coloco el "var"
            {
                Nombre = "Rudy",
                Apelllido = "Lau"
                
            };

            var miOtroObjeto = new
            {
                Raza = "Snauser",
                Nombre = "Toby"
            };
        }

        /*
         *CLASES PARCIALES: dos clases con el mismo nombre que cuando se compile sera una sola, esto sirve para poder organizar mejor en diferentes archivos. 
         */
        partial class MiClaseParcial 
        {
            public void metodoUno() 
            {
                Console.WriteLine("metodoUno");
            }
        }

        partial class MiClaseParcial
        {
            public void metodoDos()
            {
                Console.WriteLine("metodoDos");
            }
        }
    }
}
