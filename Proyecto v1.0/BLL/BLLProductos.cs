using MAPPERS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProductos
    {
        MPProductos mp;

        public BLLProductos() { mp = new MPProductos(); }

        public int CrearProducto(string pNombre, string pMarca, int pCantidad, int pPrecioUnitario, string pDescripcion, int pPrecioMinimo, int pPrecioOptimo)
        {
            return mp.CrearProducto(pNombre, pMarca, pCantidad, pPrecioUnitario, pDescripcion, pPrecioMinimo, pPrecioOptimo);
        }

        public void BajaProducto(string P)
        {
            mp.BajaProducto(P);
        }

        public void BajaHistorica(string P)
        {
            mp.BajaHistorica(P);
        }

        public void BajaVendidos(string P)
        {
            mp.BajaVendidos(P);
        }

        public void BajaTemporal(string p)
        {
            mp.BajaTemporal(p);
        }

        public void BajaTemporal2(string p)
        {
            mp.BajaTemporal2(p);
        }

        public void ModificarProductos(string id, string nom, string mar, int can, int pu, string desc, int cm, int co, int es)
        {
            mp.ModificarProductos(id, nom, mar, can, pu, desc, cm, co, es);
        }

        public void AltaProdVendidos(string id, string nom, string mar, int can, int pu, string desc, int cm, int co)
        {
            mp.AltaProdVendidos(id, nom, mar, can, pu, desc, cm, co);
        }

        public int BuscarProducto(string nombre)
        {
            return mp.BuscarProducto(nombre);
        }

        public void UpdateCantidad(int cantidad, string nombre)
        {
            mp.UpdateCantidad(cantidad, nombre);
        }

        public DataTable DevolverProductos()
        {
            return mp.DevolverProductos();
        }

        public int Porcentaje3(int i1, int i2)
        {
            return (i1 * 100) / i2;
        }

        public int Porcentaje4(int i1, int i2)
        {
            return (i1 * 100) / i2;
        }
    }
}
