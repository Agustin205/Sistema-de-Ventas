using MAPPERS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLVentas
    {
        MPVentas mp;

        public BLLVentas() { mp = new MPVentas(); }

        public DataTable DevolverProductos()
        {
            return mp.DevolverProductos();
        }

        public DataTable DevolverCarrito()
        {
            return mp.DevolverCarrito();
        }
        public void AltaCarrito(string id, string nom, string marc, int cant,int pu, string comp)
        {
            mp.AltaCarrito(id, nom, marc, cant,pu, comp);
        }

        public void BajaCarrito()
        {
            mp.BajaCarrito();
        }

        public void ActualizarCantidad(string id, int cant)
        {
            mp.ActualizarCantidad(id, cant);
        }

        public int BuscarProducto(string nom)
        {
            return mp.BuscarProducto(nom);
        }

        public void UpdateDeCantidad(string nom, int cant)
        {
            mp.UpdateCantidad(nom,cant);
        }

        public int CantMin(string nom)
        {
           return mp.CantMin(nom);
        }

        public void AltaCompras(string id, DateTime fecha, int gastado,string comp)
        {
            mp.AltaCompras(id, fecha, gastado,comp);
        }

        public void AltaVendidos(string id, string nom, string marc, int cant, int pu, string comp)
        {
            mp.AltaVendidos(id, nom, marc, cant, pu, comp);
        }

        public void AltaProductosVendidos(string id, string nom, string marc, int cant, int pu)
        {
            mp.AltaProductosVendidos(id, nom, marc, cant, pu);
        }

        public void UpdateDeCantidadVendidos(int cant, string nomb)
        {
            mp.UpdateDeCantidadVendidos(cant, nomb);
        }

        public int BuscarProductosVendidos(string nomb)
        {
            return mp.BuscarProductosVendidos(nomb);
        }

        public void UpdateCantidadInverso(int cant, string nomb)
        {
            mp.UpdateCantidadInverso(cant, nomb);
        }

        public void UpdateCantidadVendidosInverso(int cant, string nomb)
        {
            mp.UpdateCantidadVendidosInverso(cant, nomb);
        }
    }
}
