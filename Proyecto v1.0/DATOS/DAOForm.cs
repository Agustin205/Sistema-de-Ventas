using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOForm : DAOGeneral
    {
        public DAOGeneral DaoU;
        public DAOForm()
        {
            DaoU = new DAOGeneral();
            string S = "Select RTRIM(NombreForm) From Form";
            DaoU.CargarDS("Form", S);
            DaoU.RetornarDS().Tables["Form"].PrimaryKey = new DataColumn[] { DaoU.RetornarDS().Tables["Form"].Columns[0] };
        }
        public void AgregarForm(string pForm)
        {
            con.Open();
            using (var comando = new SqlCommand())
            {
                comando.Connection = con;
                comando.Parameters.AddWithValue("@NombreForm", pForm);

                comando.CommandText = $"insert into Form values (@NombreForm)";
                comando.CommandType = CommandType.Text;

                comando.ExecuteNonQuery();
            }
            con.Close();
            string S = "Select RTRIM(NombreForm) From Form";
            DaoU.CargarDS("Form", S);
        }
    }
}
