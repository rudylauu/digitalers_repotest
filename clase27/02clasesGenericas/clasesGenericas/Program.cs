using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            miClaseGenerica<string> miObjetoGenerico = new miClaseGenerica<string>();
            string valor = "Hola Soy Rudy";
            miObjetoGenerico.Mostrar(valor);
            miObjetoGenerico.OtroMostrar<string>(valor);

            miClaseGenerica<DateTime> miOtroObjetoGenerico = new miClaseGenerica<DateTime>();
            DateTime ahora = DateTime.Now;
            miOtroObjetoGenerico.Mostrar(ahora);
            miOtroObjetoGenerico.OtroMostrar<DateTime>(ahora);// o puedo colocar <string>("hola"), ya que no depende de del tipo de dato de la clase.

            Console.ReadKey();

        }
    }
}
