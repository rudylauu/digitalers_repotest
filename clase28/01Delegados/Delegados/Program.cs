using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        delegate void Escribir(string texto);
        static void Main(string[] args)
        {
            Escribir escritor = Console.WriteLine;
            escritor("Hola Mundo");

            Saludar(escritor); //llama a la funcion Saludar
            // es lo mismo que Saludar(Console.WriteLine);


            Console.ReadKey();
        }

        static void Saludar(Escribir unEscritor) 
        {
            unEscritor("Hola mundo desde la funcion Saludar");
        }
    }
}
