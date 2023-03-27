using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DAOBitacora : DAOGeneral
    {
        public void NuevaBitacoria(string usuario, string accion, int severidad, DateTime fecha)
        {
            con.Open();
            int command;
            SqlCommand comando = new SqlCommand(string.Format("SET DATEFORMAT dmy insert into Bitacora (Usuario, Accion, Severidad, Fecha) values ('{0}','{1}','{2}','{3}')", usuario, accion, severidad, fecha), con);
            command = comando.ExecuteNonQuery();
            con.Close();

        }
    }
}
