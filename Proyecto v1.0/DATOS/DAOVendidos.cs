using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOVendidos : DAOGeneral
    {
        public void BorrarPorImprimir()
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from ProductosVendidos"), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable DevolverProductosVendidos()
        {
            DataTable aux = new DataTable();
            SqlCommand comando = new SqlCommand(string.Format("select * from ProductosVendidos"), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);
            return aux;
        }

        public int CantidadUsuarios()
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("select count(*) from Usuario"), con);
            resultado = (int)comando.ExecuteScalar();
            con.Close();
            return resultado;
        }
    }
}
