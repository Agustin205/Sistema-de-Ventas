using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Producto
    {
        public Producto(string id, string nombre, string marca, int cant, int preciounitario, string descripcion, int preciomin, int precioopt, int estado)
        {
            id_Producto = id;
            Nombre = nombre;
            Marca = marca;
            Cantidad = cant;
            PrecioUnitario = preciounitario;
            Descripcion = descripcion;
            PrecioMinimo = preciomin;
            PrecioOptimo = precioopt;
            Estado = estado;
        }

        public Producto() { }

        public string id_Producto { get; set; }
       
        public string Nombre { get; set; }

        public string Marca { get; set; }

        public int Cantidad { get; set; }

        public int PrecioUnitario { get; set; }

        public string Descripcion { get; set; }

        public int PrecioMinimo { get; set; }

        public int PrecioOptimo { get; set; }
        
        public int Estado { get; set; }

    }
}
