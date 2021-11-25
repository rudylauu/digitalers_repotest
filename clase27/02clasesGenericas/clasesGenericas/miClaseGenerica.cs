using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesGenericas
{
    class miClaseGenerica<T>
    {
        public void Mostrar(T parametro) //parametro de la clase
        {
            Console.WriteLine(parametro.GetType().Name);// GetType = obtengo tipo de dato y .Name= le pido el nombre
        }

        public void OtroMostrar<T2Local>(T2Local parametro) //parametro del metodo
        {
            Console.WriteLine(parametro.GetType().Name);
        }
    }
}
