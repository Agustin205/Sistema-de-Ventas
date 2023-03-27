using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Leyenda
    {
        public string id { get; set; }
        Dictionary<string, string> Idiomas = new Dictionary<string, string>();
        public void AgregarIdioma(string pKey, string pValue)
        { Idiomas.Add(pKey, pValue); }
        public string RetornaLeyendaEnElIdioma(string pKey)
        { return Idiomas[pKey]; }
    }
}
