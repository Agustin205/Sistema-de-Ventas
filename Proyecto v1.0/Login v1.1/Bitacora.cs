using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_v1._1
{
    public partial class Bitacora : Form
    {
        public SqlConnection con;
        public Bitacora()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
        }

        public void comandosbitacora(string pconsulta)
        {
            string consulta = pconsulta;
            SqlDataAdapter ada = new SqlDataAdapter(consulta, "Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
            DataTable dt = new DataTable();
            ada.Fill(dt);
            Mostrar(dt);
        }

        public void Mostrar(DataTable dt)
        {
            dataGridView1.DataSource = dt;
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            string consulta = "Select * from Bitacora";
            comandosbitacora(consulta);
            string consulta2 = "Select usuario from Usuario";
            SqlCommand comando = new SqlCommand(consulta2, con);
            string consulta3 = "Select * from Severidad";
            SqlDataAdapter ada = new SqlDataAdapter(consulta3, "Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
            DataTable dt = new DataTable();
            ada.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Open();
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                comboBox1.Items.Add(registro["usuario"].ToString());
            }
            con.Close();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string consulta = "Select * from Bitacora order by Fecha Asc";
            comandosbitacora(consulta);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string consulta = "Select * from Bitacora where Accion = 'Iniciar Sesion' OR Accion = 'sign in' order by Fecha asc";
            comandosbitacora(consulta);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string consulta = "Select * from Bitacora where Accion = 'Iniciar Sesion' OR Accion = 'sign in' order by Fecha desc";
            comandosbitacora(consulta);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            string consulta = "Select * from Bitacora order by Fecha desc";
            comandosbitacora(consulta);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string consulta = "Select * from Bitacora where Accion = 'Register' OR Accion = 'Registro' order by Fecha asc";
            comandosbitacora(consulta);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string consulta = "Select * from Bitacora where Accion = 'Register' OR Accion = 'Registro' order by Fecha desc";
            comandosbitacora(consulta);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta = ($"Select * from Bitacora where Usuario='{comboBox1.Text}'");
            comandosbitacora(consulta);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string a = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string b = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            string cadena = "select * from Bitacora where Fecha between '" + a + "'and'" + b + "'";
            SqlDataAdapter ada = new SqlDataAdapter(cadena,con);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string a = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string b = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            string cadena = "select * from Bitacora where Fecha between '" + a + "'and'" + b + "'";
            SqlDataAdapter ada = new SqlDataAdapter(cadena, con);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Ambas_Click(object sender, EventArgs e)
        {
            string a = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string b = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            string cadena = $"select * from Bitacora where Usuario='{comboBox1.Text}' and Fecha between '" + a + "'and'" + b + "'";
            SqlDataAdapter ada = new SqlDataAdapter(cadena, con);
            DataSet ds = new DataSet();
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

    }
}
