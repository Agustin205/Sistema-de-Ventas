using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class BEIdioma
    {
        public static string IdiomaSeleccionado;
        public BEIdioma(string pNombreI) { NombreIdioma = pNombreI; }
        public string NombreIdioma { get; set; }
    }
}
