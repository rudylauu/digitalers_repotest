using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string miTexto = "Guatemala";
            Console.WriteLine(miTexto);

            miTexto = miTexto.Invertir();//invierte y se guarda en miTexto
            Console.WriteLine(miTexto);

            Console.ReadKey();//espera a que se presione una tecla
        }
    }
}
