using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOCompras : DAOGeneral
    {
        public DataTable DevolverVendidos(string id)
        {
            DataTable aux = new DataTable();

            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM Vendidos where Id_Compra = '{0}'",id), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);

            List<string> list = aux.AsEnumerable()
                           .Select(r => r.Field<string>("Comprador"))
                           .ToList();
            return aux;
        }

        public DataTable DevolverFacturas()
        {
            DataTable aux = new DataTable();

            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM Compras"), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);

            List<string> list = aux.AsEnumerable()
                           .Select(r => r.Field<string>("Comprador"))
                           .ToList();
            return aux;
        }
    }
}
