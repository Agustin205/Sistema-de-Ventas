using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace Login_v1._1
{
    public partial class UserControlLabel : UserControl
    {
        public UserControlLabel()
        {
            InitializeComponent();
        }

        public string Id { get; set; }

        public void CambioDeIdioma(List<Leyenda> pL, string pID)
        {
            {
                Leyenda _l = pL.Find(match: x => x.id == Id);
                label1.Text = _l.RetornaLeyendaEnElIdioma(pID);


            }

        }

        private void UserControlLabel_Load(object sender, EventArgs e)
        {

        }

        private void UserControlLabel_Resize(object sender, EventArgs e)
        {

        }
    }
}
