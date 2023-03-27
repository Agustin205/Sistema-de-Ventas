using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ENTIDADES;
using Servicios;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATOS
{
    public class daoUsuario
    {
        private const string conection = "Data Source=.;Initial Catalog=Proyecto;Integrated Security=True";
        public SqlConnection con;
        DataSet ds;
        SqlDataAdapter sqlda;
        SqlCommandBuilder sqlcb;

        public daoUsuario()
        {
            con = new SqlConnection(conection);
            sqlda = new SqlDataAdapter("select * from Usuario", con);
            sqlcb = new SqlCommandBuilder(sqlda);
            
            ds = new DataSet("Sistema");
            CrearTablas();
        }
        public DataSet RetornaDS() { return ds; }
        public void UpdateTablasBD() { sqlda.Update(ds); }
        public void LeerTablas() { sqlda.Fill(ds); }
        public void CrearTablas()
        {
            DataTable dtUsuario = new DataTable("Usuario");
            dtUsuario.Columns.Add("id", typeof(string));
            dtUsuario.Columns.Add("nombre", typeof(string));
            dtUsuario.Columns.Add("apellido", typeof(string));
            dtUsuario.Columns.Add("usuario", typeof(string));
            dtUsuario.Columns.Add("contraseña", typeof(string));
            dtUsuario.Columns.Add("dni", typeof(int));
            dtUsuario.Columns.Add("telefono", typeof(int));
            dtUsuario.Columns.Add("email", typeof(string));
            dtUsuario.Columns.Add("idPC", typeof(int));
            dtUsuario.Columns.Add("dvh", typeof(int));
            dtUsuario.PrimaryKey = new DataColumn[] { dtUsuario.Columns[0] };
            ds.Tables.Add(dtUsuario);

        }

        public int Autentificar(string pUsuarios,string pContraseña, bool pEsEmail)
        {


            int resultado = -1;
            con.Open();
            if(pEsEmail != true)
            {
                SqlCommand comando = new SqlCommand(string.Format("select * from Usuario where usuario = '{0}' and contraseña = '{1}'", pUsuarios, pContraseña), con);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    resultado = 50;
                }
            }
            else
            {
                SqlCommand comando = new SqlCommand(string.Format("select * from Usuario where email = '{0}' and contraseña = '{1}'", pUsuarios, pContraseña), con);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    resultado = 50;
                }
            }

            con.Close();
            return resultado;
            
        }
       
        public int CrearCuenta(string pNombre, string pApellido, string pUsuarios, string pContraseña, string pDni,string pTelefono, string pEmail)
        {
            int dvh = 0;
            string rolInicial = "Empleado2";
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Insert into Usuario (nombre,apellido,usuario,contraseña,dni,telefono,email, idPC, dvh) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')", pNombre,pApellido, pUsuarios, pContraseña,pDni,pTelefono,pEmail, rolInicial,dvh), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
            
        }

        public void BajaCuenta(string P)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Delete from Usuario where usuario = '{0}' ", P), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
        }

        public void ModificarUsuario(string usuario,string nuevo)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("Update Usuario set usuario = '{1}' where usuario = '{0}' ", usuario,nuevo), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
        }
        public string retornarID(string pUsuarios, string pContraseña)
        {
            string id = "";
            con.Open();
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand(string.Format("select idPC from Usuario where usuario = '{0}' and contraseña = '{1}'", pUsuarios, pContraseña), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow rw = dt.Rows[0];
                id = rw["idPC"].ToString();
            }
            con.Close();


            return id;



        }
        public Usuario RetornaUsuarioLogin(string usuarioNombre, string contraseña)
        {
            Usuario usuario = new Usuario();
            DataTable aux = new DataTable();
            SqlCommand comando = new SqlCommand(string.Format("select * from Usuario where usuario = '{0}' and contraseña = '{1}'", usuarioNombre, contraseña), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);

            for(int x = 0; x < aux.Rows.Count; x++)
            {
                usuario.id = aux.Rows[0]["id"].ToString();
                usuario.nombre = aux.Rows[0]["nombre"].ToString();
                usuario.apellido = aux.Rows[0]["apellido"].ToString();
                usuario.usuario = usuarioNombre;
                usuario.contraseña = contraseña;
                usuario.dni = int.Parse(aux.Rows[0]["dni"].ToString());
                usuario.telefono = int.Parse(aux.Rows[0]["telefono"].ToString());                
                usuario.email = aux.Rows[0]["email"].ToString();
                usuario.idPC = aux.Rows[0]["idPC"].ToString();
            }
            
            return usuario;
           
        }
        public void IngresarRol(string pUsuario, string pRol)
        {
            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("update Usuario set idPC = '{0}' Where usuario = '{1}'", pRol, pUsuario), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
            
        }
        public void NuevaBitacora(string usuario, string accion, int severidad, DateTime fecha)
        {
            con.Open();
            int command;
            SqlCommand comando = new SqlCommand(string.Format("SET DATEFORMAT dmy insert into Bitacora (Usuario, Accion, Severidad, Fecha) values ('{0}','{1}','{2}','{3}')", usuario, accion, severidad, fecha), con);
            command = comando.ExecuteNonQuery();
            con.Close();

        }

        public void CambiarContraseña(string email, string contraseña)
        {
            int resultado = 0;
            con.Open();
            string query = "select email from Usuario where email = '" + email + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            SqlCommand comando = new SqlCommand(string.Format("update Usuario set contraseña = '{0}' Where email = '{1}'", contraseña, email), con);
            resultado = comando.ExecuteNonQuery();
            con.Close();
        }

        public DataTable DevolverUsuarios()
        {
            DataTable aux = new DataTable();

            SqlCommand comando = new SqlCommand(string.Format("SELECT usuario, contraseña, email, idPC FROM Usuario"), con);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);

            List<string> list = aux.AsEnumerable()
                           .Select(r => r.Field<string>("usuario"))
                           .ToList();


            return aux;
        }

        public bool isForeignKey(string colName)
        {
            if (colName.Length < 4)
            {
                return false;
            }

            if (colName.Substring(colName.Length - 3, 3).Equals("_id"))
            {
                return true;
            }

            return false;
        }

        public List<string> CrearIdioma(string id, string idioma)
        {
            DataTable aux = new DataTable();

            int resultado = 0;
            con.Open();
            SqlCommand comando = new SqlCommand(string.Format("SELECT nombreIdioma, traduccion FROM Traduccion WHERE(codigoControl = '{0}') and (nombreIdioma = '{1}')", id, idioma), con);
            resultado = comando.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(aux);

            List<string> lista = new List<string>();
            List<string> listaTraduccion = new List<string>();
            foreach (DataRow dr in aux.Rows)
            {
                string nombreIdioma = dr["nombreIdioma"].ToString();
                string traduccion = dr["traduccion"].ToString();

                lista.Add(nombreIdioma);
                lista.Add(traduccion);
            }

            con.Close();

            return lista;
        }
    }
}
