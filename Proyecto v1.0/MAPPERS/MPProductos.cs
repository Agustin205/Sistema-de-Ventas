using DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPERS
{
    public class MPProductos
    {
        DAOProductos dao;

        public MPProductos() { dao = new DAOProductos(); }

        public int CrearProducto(string pNombre, string pMarca, int pCantidad, int pPrecioUnitario, string pDescripcion, int pPrecioMinimo, int pPrecioOptimo)
        {
            return dao.CrearProducto(pNombre, pMarca, pCantidad, pPrecioUnitario, pDescripcion, pPrecioMinimo, pPrecioOptimo);
        }

        public void BajaProducto(string P)
        {
            dao.BajaProducto(P);
        }

        public void BajaHistorica(string P)
        {
            dao.BajaHistorica(P);
        }

        public void BajaVendidos(string P)
        {
            dao.BajaVendidos(P);
        }

        public void BajaTemporal(string p)
        {
            dao.BajaTemporal(p);
        }

        public void BajaTemporal2(string p)
        {
            dao.BajaTemporal2(p);
        }

        public void ModificarProductos(string id, string nom, string mar, int can, int pu, string desc, int cm, int co, int es)
        {
            dao.ModificarProductos(id, nom, mar, can, pu, desc, cm, co, es);
        }

        public void AltaProdVendidos(string id, string nom, string mar, int can, int pu, string desc, int cm, int co)
        {
            dao.AltaProdVendido(id, nom, mar, can, pu, desc, cm, co);
        }

        public int BuscarProducto(string nombre)
        {
            return dao.BuscarProducto(nombre);
        }

        public void UpdateCantidad(int cantidad, string nombre)
        {
            dao.UpdateDeCantidad(cantidad, nombre);
        }

        public DataTable DevolverProductos()
        {
            return dao.DevolverProductos();
        }
    }
}
