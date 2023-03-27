using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOControl : DAOGeneral
    {
        public DAOGeneral DaoU;
        public DAOControl()
        {
            DaoU = new DAOGeneral();
            string S = "Select RTRIM(NombreControl) From Control";
            DaoU.CargarDS("Control", S);
            DaoU.RetornarDS().Tables["Control"].PrimaryKey = new DataColumn[] { DaoU.RetornarDS().Tables["Control"].Columns[0] };
        }
        public void AgregarControl(string pControl)
        {
            con.Open();
            using (var comando = new SqlCommand())
            {
                comando.Connection = con;
                comando.Parameters.AddWithValue("@NombreControl", pControl);

                comando.CommandText = $"insert into Control values (@NombreControl)";
                comando.CommandType = CommandType.Text;

                comando.ExecuteNonQuery();
            }
            con.Close();
            string S = "Select RTRIM(NombreControl) From Control";
            DaoU.CargarDS("Control", S);
        }
    }
}
