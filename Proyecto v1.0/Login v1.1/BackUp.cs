using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Servicios;

namespace Login_v1._1
{
    public partial class BackUp : Form
    {

        Servicios.BackUp BU;
        Archivo AR;
        bllBitacora bllBitacora;
        public string idioma;
        public BackUp()
        {
            InitializeComponent();
            BU = new Servicios.BackUp();
            bllBitacora = new bllBitacora();
            AR = new Archivo();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //textBox1.Text = BU.ElegirUbucacionBackUp(textBox1.Text);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\BackUp"))
            {
                BU.HacerBackUp(@"C:\BackUp");
            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(@"C:\BackUp");
                dir.Create();
                BU.HacerBackUp(@"C:\BackUp");
            }
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "BackUp Realizado", 5, DateTime.Now);
            Mostrar(dataGridView1, AR.pathArchivo());
        }

        private void Elegir_Click(object sender, EventArgs e)
        {
            //textBox2.Text = BU.EncontrarUbicacion(textBox2.Text);
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            string path = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            BU.restaurar(path);
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Restauracion Realizada", 5, DateTime.Now);
        }

        private void BackUp_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\BackUp");
            dir.Create();
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Mostrar(dataGridView1, AR.pathArchivo());
        }

        private void Mostrar(DataGridView dgv,object obj)
        {
            dgv.DataSource = null;
            dgv.DataSource = obj;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
