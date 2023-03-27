using ENTIDADES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_v1._1
{
    public partial class BitacoraB : Form
    {
        private const string conection = "Data Source=.;Initial Catalog=Proyecto;Integrated Security=True";
        public SqlConnection con;
        SqlCommand sqlcom;
        SqlDataAdapter sqlada;
        public string idioma;
        public BitacoraB()
        {
            InitializeComponent();
            con = new SqlConnection(conection);
            sqlcom = new SqlCommand("select * from Historica_Productos", con);
            sqlada = new SqlDataAdapter(sqlcom);
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void carga()
        {
            con.Open();
            DataTable dt = new DataTable();
            sqlada.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void BitacoraB_Load(object sender, EventArgs e)
        {
            carga();
        }

        private void Recomponer_Click(object sender, EventArgs e)
        {
            try
            {
                Historica hist = new Historica();
                hist.Id_HProducto = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                hist.Id_Producto = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                hist.Nombre = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                hist.Marca = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                hist.Cantidad = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                hist.PrecioUnitario = int.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
                hist.Descripcion = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                hist.PrecioMinimo = int.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                hist.PrecioOptimo = int.Parse(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                hist.Estado = bool.Parse(dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
                hist.Accion = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                con.Open();
                string consulta = ($"update Producto set Nombre = '{hist.Nombre}',Marca = '{hist.Marca}',Cantidad='{hist.Cantidad}',PrecioUnitario='{hist.PrecioUnitario}',Descripcion='{hist.Descripcion}',CantidadMinimo='{hist.PrecioMinimo}',CantidadOptimo='{hist.PrecioOptimo}',Estado='{hist.Estado}' where Id_producto = '{hist.Id_Producto}'");
                SqlCommand comando = new SqlCommand(consulta, con);
                comando.ExecuteNonQuery();
                con.Close();
                MessageBox.Show($"Se recompuso el estado de {hist.Nombre}");
                carga();
            }
            catch (Exception) { MessageBox.Show("Hubo un error"); }
        }
    }
}
