using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOVentas : DAOGeneral
    {
        public DataTable DevolverProductos()
        {
            DataTable aux = new DataTable();

            SqlCommand comando = new SqlCommand(string.Format("SELECT Id_Producto,Nombre,Marca,Cantidad,PrecioUnitario FROM Producto"), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);

            List<string> list = aux.AsEnumerable()
                           .Select(r => r.Field<string>("Nombre"))
                           .ToList();
            return aux;
        }

        public DataTable DevolverCarrito()
        {
            DataTable aux = new DataTable();

            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM Carrito"), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);

            List<string> list = aux.AsEnumerable()
                           .Select(r => r.Field<string>("Nombre"))
                           .ToList();
            return aux;
        }

        public void AltaCarrito(string id, string nom, string marc,int cant,int pu, string comp)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("insert into Carrito values('{0}','{1}','{2}','{3}','{4}','{5}')", id, nom, marc, cant,pu,comp), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void BajaCarrito()
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from Carrito"), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void ModificarCantidad(string id,int cantidad)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update Producto set Cantidad = '{1}' where Id_Producto = '{0}'", id, cantidad), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
        }

        public int BuscarProducto(string nombre)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("select count(*) from Carrito where Nombre = '{0}'", nombre), con);
            resultado = (int)comando.ExecuteScalar();
            con.Close();
            return resultado;
        }

        public void UpdateDeCantidad(int cantidad, string nombre)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("update Carrito set Cantidad += {0} where Nombre = '{1}'", cantidad, nombre), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public int CantMin(string nombre)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("select CantidadMinimo from Producto where Nombre = '{0}'", nombre), con);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = reader.GetInt32(0);
            }
            con.Close();
            return resultado;
        }

        public void AltaCompras(string id, DateTime fecha, int gastado,string comp)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("insert into Compras values('{0}','{1}','{2}','{3}')", id, fecha, gastado,comp), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void AltaVendidos(string id, string nom, string marc, int cant, int pu, string comp)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("insert into Vendidos values('{0}','{1}','{2}','{3}','{4}','{5}')", id, nom, marc, cant, pu, comp), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void AltaProductosVendidos(string id, string nom, string marc, int cant, int pu)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("insert into ProductosVendidos values('{0}','{1}','{2}','{3}','{4}')", id, nom, marc, cant, pu), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateDeCantidadVendidos(int cantidad, string nombre)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("update ProductosVendidos set Cantidad += {0} where Nombre = '{1}'", cantidad, nombre), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public int BuscarProductosVendidos(string nombre)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("select count(*) from ProductosVendidos where Nombre = '{0}'", nombre), con);
            resultado = (int)comando.ExecuteScalar();
            con.Close();
            return resultado;
        }

        public void UpdateCantidadInverso(int cantidad, string nombre)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("update Producto set Cantidad += {0} where Nombre = '{1}'", cantidad, nombre), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void UpdateCantidadVendidosInverso(int cantidad, string nombre)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("update ProductosVEndidos set Cantidad -= {0} where Nombre = '{1}'", cantidad, nombre), con);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
