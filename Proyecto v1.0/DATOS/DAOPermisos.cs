using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATOS
{
    public class DAOPermisos : DAOGeneral
    {
        public List<string> PermisosUsuario(Usuario pUsuario)
        {
            DataTable aux = new DataTable();

            string nombre = pUsuario.usuario;
            string id = pUsuario.idPC;
            SqlCommand comando = new SqlCommand(string.Format("SELECT [PC-PS].idPermiso FROM Usuario CROSS JOIN [PC-PS] WHERE (Usuario.usuario = '{0}' and [PC-PS].idPC = '{1}')", pUsuario.usuario, pUsuario.idPC), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);


            List<string> list = aux.AsEnumerable()
                           .Select(r => r.Field<string>("idPermiso"))
                           .ToList();


            return list;


        }

        public List<string> PermisosUsuarioID(string usuario, string idPC)
        {
            DataTable aux = new DataTable();

            SqlCommand comando = new SqlCommand(string.Format("SELECT [PC-PS].idPermiso FROM Usuario CROSS JOIN [PC-PS] WHERE (Usuario.usuario = '{0}' and [PC-PS].idPC = '{1}')", usuario, idPC), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);


            List<string> list = aux.AsEnumerable()
                           .Select(r => r.Field<string>("idPermiso"))
                           .ToList();


            return list;


        }

        public List<string> TodosLosPermisos()
        {
            DataTable aux = new DataTable();

            SqlCommand comando = new SqlCommand(string.Format("SELECT idPC, usuario FROM Usuario"), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);

            List<string> list = aux.AsEnumerable()
                           .Select(r => r.Field<string>("idPC"))
                           .ToList();


            return list;
        }

        public int InsertarPermisos(string PC, string PS)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Insert into [PC-PS] (idPC,idPermiso,Estado) values ('{0}','{1}','{2}')", PC, PS, 1), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }

        public int InsertarEnPermisosID(string PC)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Insert into Permiso (idPermiso) values ('{0}')", PC), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }

        public int BorrarPermisos(string PC)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from [PC-PS] where idPC = '{0}' ", PC), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }

        public int BorrarPermisosEnID(string PC)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from Permiso where idPermiso = '{0}' ", PC), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }

        public int ModificarPermisos(string PC, string PS)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update [PC-PS] set idPermiso = '{1}' where idPC = '{0}' ", PC, PS), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }

        public int ModificarPermisosPersona(string usuario, string PC)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update Usuario set idPC = '{0}' where  Usuario.usuario = '{1}' ", PC, usuario), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }

        public void ModificarNull(string PC, string A)
        {
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update Usuario set idPC = '{0}' where  idPC = '{1}' ", PC, A), con);
            comando.ExecuteNonQuery();
            con.Close();
        }

        public void LlenarCombo(ComboBox cb)
        {
            con.Open();
            string consulta = "Select * from Permiso";
            SqlCommand comando = new SqlCommand(consulta, con);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                cb.Items.Add(registro["idPermiso"].ToString());
            }
            con.Close();
        }
    }
}
