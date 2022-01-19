using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]//para que me tome el ViewState
    public class Comentario
    {// creo una carpeta--> creo una clase Comentario.cs--> creo las properties con NIPET(buscar que es)
     // para crearlas mas rapido: prop "TAB" "TAB"
        
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Texto { get; set; }
    }
}
