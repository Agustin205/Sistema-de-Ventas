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
    public partial class NotaDePedido : Form
    {
        public NotaDePedido()
        {
            InitializeComponent();
        }

        private void NotaDePedido_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetProductosVendidos.ProductosVendidos' Puede moverla o quitarla según sea necesario.
            this.ProductosVendidosTableAdapter.Fill(this.DataSetProductosVendidos.ProductosVendidos);

            this.reportViewer1.RefreshReport();
        }
    }
}
