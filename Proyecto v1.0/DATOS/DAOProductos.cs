using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOProductos : DAOGeneral
    {
        public int CrearProducto(string pNombre, string pMarca, int pCantidad, int pPrecioUnitario, string pDescripcion, int pPrecioMinimo, int pPrecioOptimo)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Insert into Producto (Nombre,Marca,Cantidad,PrecioUnitario,Descripcion,CantidadMinimo,CantidadOptimo,Estado) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", pNombre, pMarca, pCantidad, pPrecioUnitario, pDescripcion, pPrecioMinimo, pPrecioOptimo, 1), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;

        }

        public void BajaProducto(string P)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from Producto where Id_Producto = '{0}' ", P), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
        }

        public void BajaHistorica(string P)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from Historica_Productos where Id_Producto = '{0}' ", P), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void BajaVendidos(string P)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from ProductosVendidos where Id_Producto = '{0}' ", P), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void BajaTemporal(string p)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update Producto set Estado = '{0}' where Id_Producto = '{1}'", false, p), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
        }

        public void BajaTemporal2(string p)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update Producto set Estado = '{0}' where Id_Producto = '{1}'", true, p), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
        }

        public void ModificarProductos(string id, string nom, string mar, int can, int pu, string desc, int cm, int co, int es)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update Producto set Nombre = '{1}',Marca = '{2}',Cantidad = '{3}',PrecioUnitario = '{4}',Descripcion = '{5}',CantidadMinimo = '{6}',CantidadOptimo = '{7}',Estado = '{8}' where Id_Producto = '{0}'", id, nom, mar, can, pu, desc, cm, co, es), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
        }

        public void AltaProdVendido(string id, string nom, string mar, int can, int pu, string desc, int cm, int co)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("insert into ProductosVendidos values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", id, nom, mar, can, pu, desc, cm, co, 1), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public int BuscarProducto(string nombre)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("select count(*) from ProductosVendidos where Nombre = '{0}'", nombre), con);
            resultado = (int)comando.ExecuteScalar();
            con.Close();
            return resultado;
        }

        public void UpdateDeCantidad(int cantidad, string nombre)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("update ProductosVendidos set Cantidad += {0} where Nombre = '{1}'", cantidad, nombre), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable DevolverProductos()
        {
            DataTable aux = new DataTable();

            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM Producto"), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);

            List<string> list = aux.AsEnumerable()
                           .Select(r => r.Field<string>("Nombre"))
                           .ToList();
            return aux;
        }
    }
}
