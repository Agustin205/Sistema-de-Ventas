using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOIdioma : DAOGeneral
    {
        public DAOGeneral DaoU;
        public DAOIdioma()
        {
            DaoU = new DAOGeneral();
            string S = "Select RTRIM(NombreIdioma) From Idioma";
            DaoU.CargarDS("Idioma", S);
            DaoU.RetornarDS().Tables["Idioma"].PrimaryKey = new DataColumn[] { DaoU.RetornarDS().Tables["Idioma"].Columns[0] };
        }
        public void AgregarIdioma(string pIdioma)
        {
            con.Open();
            using (var comando = new SqlCommand())
            {
                comando.Connection = con;
                comando.Parameters.AddWithValue("@NombreIdioma", pIdioma);

                comando.CommandText = $"insert into Idioma values (@NombreIdioma)";
                comando.CommandType = CommandType.Text;

                comando.ExecuteNonQuery();
            }
            con.Close();
            string S = "Select RTRIM(NombreIdioma) From Idioma";
            DaoU.CargarDS("Idioma", S);
        }

        public void BajaIdioma(string I)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from Idioma where NombreIdioma = '{0}' ", I), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void BajaIdioma2(string I)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from Traduccion where Trad_NombreIdioma = '{0}' ", I), con);
            comando.ExecuteNonQuery();
            con.Close();
        }
    }
}
