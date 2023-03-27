using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOFormControl : DAOGeneral
    {
        public DAOGeneral DaoU;
        public DAOFormControl()
        {
            DaoU = new DAOGeneral();
            string S = "Select FC_NombreForm,FC_NombreControl From [Form-Control]";
            DaoU.CargarDS("[Form-Control]", S);
            DaoU.RetornarDS().Tables["[Form-Control]"].PrimaryKey = new DataColumn[] { DaoU.RetornarDS().Tables["[Form-Control]"].Columns[0], DaoU.RetornarDS().Tables["[Form-Control]"].Columns[1] };
        }
        public void AgregarFormControl(string pForm, string pControl)
        {

            con.Open();

            using (var comando = new SqlCommand())
            {
                comando.Connection = con;
                comando.Parameters.AddWithValue("@Form", pForm);
                comando.Parameters.AddWithValue("@Control", pControl);

                comando.CommandText = $"insert into [Form-Control] values (@Form,@Control)";
                comando.CommandType = CommandType.Text;

                comando.ExecuteNonQuery();
            }
            con.Close();
            string S = "Select FC_NombreForm,FC_NombreControl From [Form-Control]";
            DaoU.CargarDS("[Form-Control]", S);
        }
    }
}
