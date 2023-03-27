using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOTraduccion : DAOGeneral
    {
        public DAOGeneral DaoU;
        public DAOTraduccion()
        {
            DaoU = new DAOGeneral();
            string S = "Select Trad_NombreIdioma,Trad_NombreForm,Trad_NombreControl,RTRIM(Traduccion) From Traduccion";
            DaoU.CargarDS("Traduccion", S);
            DaoU.RetornarDS().Tables["Traduccion"].PrimaryKey = new DataColumn[] { DaoU.RetornarDS().Tables["Traduccion"].Columns[0], DaoU.RetornarDS().Tables["Traduccion"].Columns[1], DaoU.RetornarDS().Tables["Traduccion"].Columns[2] };
        }
        public void AgregarTraduccion(string pIdioma, string pForm, string pControl, string pTraduccion)
        {
            con.Open();

            using (var comando = new SqlCommand())
            {
                comando.Connection = con;
                comando.Parameters.AddWithValue("@Idioma", pIdioma);
                comando.Parameters.AddWithValue("@Form", pForm);
                comando.Parameters.AddWithValue("@Control", pControl);
                comando.Parameters.AddWithValue("@Traduccion", pTraduccion);

                comando.CommandText = $"insert into Traduccion values (@Idioma,@Form,@Control,@Traduccion)";
                comando.CommandType = CommandType.Text;

                comando.ExecuteNonQuery();
            }
            con.Close();
            string S = "Select Trad_NombreIdioma,Trad_NombreForm,Trad_NombreControl,RTRIM(Traduccion) From Traduccion";
            DaoU.CargarDS("Traduccion", S);

        }
        public void ModificarTraduccion(string pIdioma, string pForm, string pControl, string pTraduccion)
        {
            con.Open();
            using (var comando = new SqlCommand())
            {
                comando.Connection = con;

                comando.Parameters.AddWithValue("@NombreIdioma", pIdioma);
                comando.Parameters.AddWithValue("@NombreForm", pForm);
                comando.Parameters.AddWithValue("@NombreControl", pControl);
                comando.Parameters.AddWithValue("@Traduccion", pTraduccion);
                comando.CommandText = $"update Traduccion set Traduccion = @Traduccion where Trad_NombreIdioma = @NombreIdioma and Trad_NombreForm = @NombreForm and Trad_NombreControl = @NombreControl";
                comando.CommandType = CommandType.Text;

                comando.ExecuteNonQuery();
            }
            con.Close();
            string S = "Select Trad_NombreIdioma,Trad_NombreForm,Trad_NombreControl,RTRIM(Traduccion) From Traduccion";
            DaoU.CargarDS("Traduccion", S);

        }
    }
}
