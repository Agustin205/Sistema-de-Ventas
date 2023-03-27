using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Propuesta
    {
        public string id { get; set; }

        public DateTime FechaInicio { get; set; }

        public bool Disponibilidad { get; set; }

        public int Costo { get; set; }

        public int duracion { get; set; }
    }
}
