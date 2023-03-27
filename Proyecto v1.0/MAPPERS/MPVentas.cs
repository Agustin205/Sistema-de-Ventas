using DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPERS
{
    public class MPVentas
    {
        DAOVentas dao;

        public MPVentas() { dao = new DAOVentas(); }

        public DataTable DevolverProductos()
        {
            return dao.DevolverProductos();
        }

        public DataTable DevolverCarrito()
        {
            return dao.DevolverCarrito();
        }
        public void AltaCarrito(string id, string nom, string marc, int cant,int pu, string comp)
        {
            dao.AltaCarrito(id, nom, marc, cant,pu, comp);
        }

        public void BajaCarrito()
        {
            dao.BajaCarrito();
        }

        public void ActualizarCantidad(string id, int cant)
        {
            dao.ModificarCantidad(id, cant);
        }

        public int BuscarProducto(string nom)
        {
           return dao.BuscarProducto(nom);
        }

        public void UpdateCantidad(string nom,int cant)
        {
            dao.UpdateDeCantidad(cant,nom);
        }

        public int CantMin(string nom)
        {
            return dao.CantMin(nom);
        }

        public void AltaCompras(string id, DateTime fecha, int gastado,string comp)
        {
            dao.AltaCompras(id, fecha,gastado,comp);
        }

        public void AltaVendidos(string id, string nom, string marc, int cant, int pu, string comp)
        {
            dao.AltaVendidos(id, nom, marc, cant, pu, comp);
        }

        public void AltaProductosVendidos(string id,string nom,string marc,int cant, int pu)
        {
            dao.AltaProductosVendidos(id,nom,marc,cant,pu);
        }

        public void UpdateDeCantidadVendidos(int cant, string nomb)
        {
            dao.UpdateDeCantidadVendidos(cant, nomb);
        }

        public int BuscarProductosVendidos(string nomb)
        {
            return dao.BuscarProductosVendidos(nomb);
        }

        public void UpdateCantidadInverso(int cant,string nomb)
        {
            dao.UpdateCantidadInverso(cant,nomb);
        }

        public void UpdateCantidadVendidosInverso(int cant, string nomb)
        {
            dao.UpdateCantidadVendidosInverso(cant, nomb);
        }
    }
}
