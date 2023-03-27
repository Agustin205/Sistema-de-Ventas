using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class BETraduccion
    {
        public BETraduccion(BEIdioma pIdioma, BEForm pForm, BEControl pControl, string pTraduccion)
        {
            Idioma = pIdioma;
            Form = pForm;
            Control = pControl;
            Traduccion = pTraduccion;
        }

        public BEIdioma Idioma { get; set; }
        public BEForm Form { get; set; }
        public BEControl Control { get; set; }
        public string Traduccion { get; set; }
    }
}
