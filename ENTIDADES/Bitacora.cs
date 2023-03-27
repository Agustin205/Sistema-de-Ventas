using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Bitacora
    {
        public Bitacora() { }
        public string Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Accion { get; set; }
        public int Severidad { get; set; }
        public DateTime Fecha { get; set; }     
    }
}
