using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_v1._1
{
    public partial class Facturas : Form
    {
        BLLCompras bll;
        public Facturas()
        {
            InitializeComponent();
            bll = new BLLCompras();
        }

        private void VerProd_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            dataGridView2.DataSource = bll.DevolverVendidos(id);
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.DevolverFacturas();
        }
    }
}
