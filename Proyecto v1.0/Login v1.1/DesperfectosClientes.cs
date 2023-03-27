using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTIDADES;
using Servicios;

namespace Login_v1._1
{
    public partial class DesperfectosClientes : Form
    {

        bllUsuario bll;
        public DesperfectosClientes()
        {
            InitializeComponent();
            bll = new bllUsuario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
