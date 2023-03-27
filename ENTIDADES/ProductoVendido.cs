using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class ProductoVendido
    {
        public ProductoVendido()
        {
        }

        public ProductoVendido(string id, string nombre, string marca, int cant, int preciounitario)
        {
            id_Producto = id;
            Nombre = nombre;
            Marca = marca;
            Cantidad = cant;
            PrecioUnitario = preciounitario;
        }

        public string id_Producto { get; set; }

        public string Nombre { get; set; }

        public string Marca { get; set; }

        public int Cantidad { get; set; }

        public int PrecioUnitario { get; set; }
    }
}
