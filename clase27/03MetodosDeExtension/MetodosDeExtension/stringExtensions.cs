using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    public static class stringExtensions
    {
        //cuando se llame a este metodo se va a llamar como:
        //variable.Invertir()
        //y "self" va a corresponder como "variable"

        public static string Invertir(this string self) 
        {
            char[] array = self.ToCharArray(); //convierto a Array
            Array.Reverse(array);  // revertir el array
            return new string(array); //retorno el nuevo string
        }
    }
}
