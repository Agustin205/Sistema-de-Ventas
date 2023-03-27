using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Historica
    {
        
        public string Id_HProducto { get; set; }
        public string Id_Producto { get; set; }

        public string Nombre { get; set; }

        public string Marca { get; set; }

        public int Cantidad { get; set; }

        public int PrecioUnitario { get; set; }

        public string Descripcion { get; set; }

        public int PrecioMinimo { get; set; }

        public int PrecioOptimo { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Accion { get; set; }
    }
}
