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
    public partial class UserControlBotones : UserControl
    {
        public UserControlBotones()
        {
            InitializeComponent();
        }

        public string Id { get; set; }

        public void CambioDeIdioma(List<Leyenda> pL, string pID)
        {
            {
                Leyenda _l = pL.Find(match: x => x.id == Id);
                button1.Text = _l.RetornaLeyendaEnElIdioma(pID);
            }
        }

        private void UserControlBotones_Load(object sender, EventArgs e)
        {
            UserControlBotones_Resize(null, null);
        }

        private void UserControlBotones_Resize(object sender, EventArgs e)
        {
            button1.Size = this.Size;
        }
    }
}
