using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOGeneral
    {
        SqlDataAdapter sqlDa;
        SqlCommandBuilder sqlCb;
        DataSet DS;
        private const string conection = "Data Source=.;Initial Catalog=Proyecto;Integrated Security=True";
        public SqlConnection con;
        public DAOGeneral()
        {
            con = new SqlConnection(conection);
            sqlDa = new SqlDataAdapter("Select * from Usuario",con);
            sqlCb = new SqlCommandBuilder(sqlDa);
            sqlDa.InsertCommand = sqlCb.GetInsertCommand();
            sqlDa.DeleteCommand = sqlCb.GetDeleteCommand();
            sqlDa.UpdateCommand = sqlCb.GetUpdateCommand();
            DS = new DataSet("Datos");
        }
        public void CargarDS(string pTabla, string pCommand)
        {
            sqlDa.SelectCommand.CommandText = pCommand;
            sqlDa.Fill(DS, pTabla);
        }
        public void Grabar()
        {
            sqlDa.Update(DS);
        }

        public DataSet RetornarDS()
        {
            return DS;
        }
    }
}
