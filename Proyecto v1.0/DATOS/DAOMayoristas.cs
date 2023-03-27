using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOMayoristas : DAOGeneral 
    {
        public void AltaMayoristas(string id, string nom, string direc)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("insert into Mayoristas values('{0}','{1}','{2}')", id, nom, direc, 1), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void BajaMayoristas(string P)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from Mayoristas where Id_Mayoristas = '{0}' ", P), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void ModificarProductos(string id,string nom,string direc)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update Mayoristas set Nombre = '{1}',Direccion = '{2}' where Id_Mayoristas = '{0}'", id, nom, direc), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable DevolverMayoristas()
        {
            DataTable aux = new DataTable();

            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM Mayoristas"), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);

            List<string> list = aux.AsEnumerable()
                           .Select(r => r.Field<string>("Id_Mayoristas"))
                           .ToList();
            return aux;
        }
    }
}
