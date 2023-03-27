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
using ENTIDADES;
using BLL;

namespace Login_v1._1
{
    public partial class MainMenu : Form
    {
        List<Leyenda> _l;
        CambioIdioma _cambioIdioma;
        BLLControl _bllC;
        bllUsuario bll;
        BLLPermisos bllp;
        bllBitacora bllBitacora;
        public BLLForm _bllF;
        public BLLTraduccion _bllT;
        public BLLIdioma _bllI;
        public string usuario;
        public string contraseña;
        public string idioma;
        public string IdiomaSeleccionado;
        private Timer ti;
        public MainMenu()
        {
            InitializeComponent();
            bll = new bllUsuario();
            bllp = new BLLPermisos();
            bllBitacora = new bllBitacora();
            _l = new List<Leyenda>();
            _cambioIdioma = new CambioIdioma(_l);
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            ti.Enabled = true;
            _bllC = new BLLControl();
            _bllF = new BLLForm();
            _bllT = new BLLTraduccion();
            _bllI = new BLLIdioma();
        }

        private void eventoTimer(object obj,EventArgs evt)
        {
            DateTime hoy = DateTime.Now;
            label2.Text = hoy.ToString("hh:mm:ss:tt");
        }

        PermisoCompuesto pc1;
        Usuario _u;
        Perfil _p01;
        List<string> listaAux;
        public void ValidarForm()
        {

            if (Singleton.Instancia.EstaLogeado())
                this.toolStripSesion.Text = Singleton.Instancia._usuarioS.usuario;
            else
                this.toolStripSesion.Text = "Sesión no iniciada";

            _u = Singleton.Instancia._usuarioS; 
            List<string> listaAux = new List<string>();
            foreach(string p in bllp.PermisosUsuario(_u)) 
            {
                listaAux.Add(p);
                
            }

            pc1 = new PermisoCompuesto("C01");
            for (int x = 0; x < listaAux.Count; x++) 
            {
                PermisoSimple p = new PermisoSimple(listaAux[x]);
                
                pc1.AgregarPermiso(p); 
            }
            _p01 = new Perfil(pc1); 

            _u.Perfil = _p01; 
            Mostrar();
            


          
        }

        private void Mostrar()
        {
            List<ToolStripMenuItem> _b = new List<ToolStripMenuItem>();

            foreach (ToolStripMenuItem c in this.menuStrip1.Items)
            {
                if (c is ToolStripMenuItem)
                {
                    (c as ToolStripMenuItem).Visible = false;
                    if (_u.Perfil.Validar(c.Tag.ToString().Split(',')[0]))
                    {
                        _b.Add(c as ToolStripMenuItem);
                    }
                }
            }

            foreach (ToolStripMenuItem c in this.administradorToolStripMenuItem.DropDownItems)
            {
                if (c is ToolStripMenuItem)
                {
                    (c as ToolStripMenuItem).Visible = false;
                    if (_u.Perfil.Validar(c.Tag.ToString().Split(',')[0]))
                    {
                        _b.Add(c as ToolStripMenuItem);
                    }
                }
            }

            foreach (ToolStripMenuItem c in this.negocioToolStripMenuItem.DropDownItems)
            {
                if (c is ToolStripMenuItem)
                {
                    (c as ToolStripMenuItem).Visible = false;
                    if (_u.Perfil.Validar(c.Tag.ToString().Split(',')[0]))
                    {
                        _b.Add(c as ToolStripMenuItem);
                    }
                }
            }


            _b.Sort(new Orden());
            foreach (ToolStripMenuItem c in _b) { c.Visible = true; }
        }
        public class Orden : IComparer<ToolStripMenuItem>
        {
            public int Compare(ToolStripMenuItem x, ToolStripMenuItem y)
            {
                int rdo = 0;
                if (int.Parse(x.Tag.ToString().Split(',')[1]) < int.Parse(y.Tag.ToString().Split(',')[1])) { rdo = -1; }
                if (int.Parse(x.Tag.ToString().Split(',')[1]) > int.Parse(y.Tag.ToString().Split(',')[1])) { rdo = 1; }
                return rdo;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Logout", 1, DateTime.Now);
                bll.Logout();

                Application.Exit();
            }
            catch (Exception ex) { throw ex; } 
        }



        public void Idioma()
        {
            Leyenda b3 = new Leyenda() { id = "b3" };
            Leyenda b4 = new Leyenda() { id = "b4" };
            Leyenda b5 = new Leyenda() { id = "b5" };
            Leyenda b6 = new Leyenda() { id = "b6" };
            Leyenda b7 = new Leyenda() { id = "b7" };
            Leyenda b8 = new Leyenda() { id = "b8" };
            Leyenda l5 = new Leyenda() { id = "l5" };

            List<string> listab3 = new List<string>(bll.CrearIdioma("b3", "eng"));
            b3.AgregarIdioma(listab3[0], listab3[1]);

            List<string> listab4 = new List<string>(bll.CrearIdioma("b4", "eng"));
            b4.AgregarIdioma(listab4[0], listab4[1]);

            List<string> listab5 = new List<string>(bll.CrearIdioma("b5", "eng"));
            b5.AgregarIdioma(listab5[0], listab5[1]);

            List<string> listab6 = new List<string>(bll.CrearIdioma("b6", "eng"));
            b6.AgregarIdioma(listab6[0], listab6[1]);

            List<string> listab7 = new List<string>(bll.CrearIdioma("b7", "eng"));
            b7.AgregarIdioma(listab7[0], listab7[1]);

            List<string> listab8 = new List<string>(bll.CrearIdioma("b8", "eng"));
            b8.AgregarIdioma(listab8[0], listab8[1]);

            List<string> listal5 = new List<string>(bll.CrearIdioma("l5", "eng"));
            l5.AgregarIdioma(listal5[0], listal5[1]);

            List<string> listab32 = new List<string>(bll.CrearIdioma("b3", "esp"));
            b3.AgregarIdioma(listab32[0], listab32[1]);

            List<string> listab42 = new List<string>(bll.CrearIdioma("b4", "esp"));
            b4.AgregarIdioma(listab42[0], listab42[1]);

            List<string> listab52 = new List<string>(bll.CrearIdioma("b5", "esp"));
            b5.AgregarIdioma(listab52[0], listab52[1]);

            List<string> listab62 = new List<string>(bll.CrearIdioma("b6", "esp"));
            b6.AgregarIdioma(listab62[0], listab62[1]);

            List<string> listab72 = new List<string>(bll.CrearIdioma("b7", "esp"));
            b7.AgregarIdioma(listab72[0], listab72[1]);

            List<string> listab82 = new List<string>(bll.CrearIdioma("b8", "esp"));
            b8.AgregarIdioma(listab82[0], listab82[1]);

            List<string> listal51 = new List<string>(bll.CrearIdioma("l5", "esp"));
            l5.AgregarIdioma(listal51[0], listal51[1]);



            _l.AddRange(new Leyenda[] { b3, b4, b5, b6, b7, b8, l5});


            _cambioIdioma.Idioma = idioma;

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //Idioma();
            foreach(Control c in this.Controls)
            {
                if(c is MdiClient)
                {
                    c.BackgroundImageLayout = ImageLayout.Center;
                    c.BackColor = Color.Yellow;
                }
            }


            foreach (BEControl C in _bllF.RetornarControles(this.Name.ToString()))
            {
                foreach (Control _c in this.Controls)
                {
                    if (_c.Name == C.NombreControl)
                    {
                        _c.Text = _bllT.Traducir(IdiomaSeleccionado, this.Name.ToString(), C.NombreControl);
                    }
                }
            }

            List<ToolStripMenuItem> _b = new List<ToolStripMenuItem>();

            foreach (BEControl C in _bllF.RetornarControles(this.Name.ToString()))
            {
                foreach (ToolStripMenuItem _c in this.menuStrip1.Items)
                {
                    if (_c is ToolStripMenuItem)
                    {
                        if (_c.Name == C.NombreControl)
                        {
                            _c.Text = _bllT.Traducir(BEIdioma.IdiomaSeleccionado, this.Name.ToString(), C.NombreControl);
                        }
                    }
                }
            }

            foreach (BEControl C in _bllF.RetornarControles(this.Name.ToString()))
            {
                foreach (ToolStripMenuItem _c in this.negocioToolStripMenuItem.DropDownItems)
                {
                    if (_c is ToolStripMenuItem)
                    {
                        if (_c.Name == C.NombreControl)
                        {
                            _c.Text = _bllT.Traducir(BEIdioma.IdiomaSeleccionado, this.Name.ToString(), C.NombreControl);
                        }
                    }
                }
            }

            foreach (BEControl C in _bllF.RetornarControles(this.Name.ToString()))
            {
                foreach (ToolStripMenuItem _c in this.administradorToolStripMenuItem.DropDownItems)
                {
                    if (_c is ToolStripMenuItem)
                    {
                        if (_c.Name == C.NombreControl)
                        {
                            _c.Text = _bllT.Traducir(BEIdioma.IdiomaSeleccionado, this.Name.ToString(), C.NombreControl);
                        }
                    }
                }
            }

            comboBox1.DataSource = _bllI.RetornarLista();
            comboBox1.DisplayMember = "NombreIdioma";
            comboBox1.ValueMember = "NombreIdioma";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedValue = IdiomaSeleccionado;
            BEIdioma.IdiomaSeleccionado = IdiomaSeleccionado;
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Permisos", 3, DateTime.Now);

            Permisos pc = new Permisos();
            pc.MdiParent = this;
            pc.AutoSize = true;
            TraducirForm(pc);
            pc.Show();
            pc.WindowState = FormWindowState.Maximized;

        }

        public void TraducirForm(Form form)
        {
            foreach (BEControl C in _bllF.RetornarControles(form.Name.ToString()))
            {
                foreach (Control _c in form.Controls)
                {
                    if (_c.Name == C.NombreControl)
                    {
                        _c.Text = _bllT.Traducir(BEIdioma.IdiomaSeleccionado, form.Name.ToString(), C.NombreControl);
                    }
                }
            }
        }
        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Reporte nuevo", 2, DateTime.Now);
            Bitacora BC = new Bitacora();
            BC.MdiParent = this;
            BC.AutoSize = true;
            TraducirForm(BC);
            BC.Show();
            BC.WindowState = FormWindowState.Maximized;
        }

        private void controlDeCambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Control de Cambios", 1, DateTime.Now);
            BitacoraB BB = new BitacoraB();
            BB.MdiParent = this;
            BB.AutoSize = true;
            TraducirForm(BB);
            BB.Show();
            BB.WindowState = FormWindowState.Maximized;
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "BackUp/Restore", 1, DateTime.Now);
            BackUp BU = new BackUp();
            BU.MdiParent = this;
            BU.AutoSize = true;
            TraducirForm(BU);
            BU.Show();
            BU.WindowState = FormWindowState.Maximized;
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Productos", 3, DateTime.Now);
            Productos PR = new Productos();
            PR.MdiParent = this;
            PR.AutoSize = true;
            TraducirForm(PR);
            PR.Show();
            PR.WindowState = FormWindowState.Maximized;
        }

        private void vendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Productos Descontados", 3, DateTime.Now);
            ProductosVendidos PV = new ProductosVendidos();
            PV.MdiParent = this;
            PV.AutoSize = true;
            TraducirForm(PV);
            PV.Show();
            PV.WindowState = FormWindowState.Maximized;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Logout", 1, DateTime.Now);
                bll.Logout();

                Application.Exit();
            }
            catch (Exception ex) { throw ex; }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            while (this.MdiChildren.Length >= 1)
            {
                this.MdiChildren.First().Close();
            }
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void multiIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "MultiIdioma", 3, DateTime.Now);
            FormIdioma FI = new FormIdioma();
            FI.MdiParent = this;
            FI.AutoSize = true;
            FI.Show();
            TraducirForm(FI);
            FI.WindowState = FormWindowState.Maximized;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BEIdioma.IdiomaSeleccionado = comboBox1.SelectedValue.ToString();

            if (this.ActiveMdiChild != null)
            {
                foreach (BEControl C in _bllF.RetornarControles(this.ActiveMdiChild.Name.ToString()))
                {
                    foreach (Control _c in this.ActiveMdiChild.Controls)
                    {
                        if (_c.Name == C.NombreControl)
                        {
                            _c.Text = _bllT.Traducir(comboBox1.SelectedValue.ToString(), this.ActiveMdiChild.Name.ToString(), C.NombreControl);
                        }
                    }
                }
            }

            List<ToolStripMenuItem> _b = new List<ToolStripMenuItem>();

            foreach (BEControl C in _bllF.RetornarControles(this.Name.ToString()))
            {
                foreach (ToolStripMenuItem _c in this.menuStrip1.Items)
                {
                    if (_c is ToolStripMenuItem)
                    {
                        if (_c.Name == C.NombreControl)
                        {
                            _c.Text = _bllT.Traducir(BEIdioma.IdiomaSeleccionado, this.Name.ToString(), C.NombreControl);
                        }
                    }
                }
            }

            foreach (BEControl C in _bllF.RetornarControles(this.Name.ToString()))
            {
                foreach (ToolStripMenuItem _c in this.negocioToolStripMenuItem.DropDownItems)
                {
                    if (_c is ToolStripMenuItem)
                    {
                        if (_c.Name == C.NombreControl)
                        {
                            _c.Text = _bllT.Traducir(BEIdioma.IdiomaSeleccionado, this.Name.ToString(), C.NombreControl);
                        }
                    }
                }
            }

            foreach (BEControl C in _bllF.RetornarControles(this.Name.ToString()))
            {
                foreach (ToolStripMenuItem _c in this.administradorToolStripMenuItem.DropDownItems)
                {
                    if (_c is ToolStripMenuItem)
                    {
                        if (_c.Name == C.NombreControl)
                        {
                            _c.Text = _bllT.Traducir(BEIdioma.IdiomaSeleccionado, this.Name.ToString(), C.NombreControl);
                        }
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas vn = new Ventas();
            vn.MdiParent = this;
            vn.AutoSize = true;
            vn.Show();
            //TraducirForm(FI);
            vn.WindowState = FormWindowState.Maximized;
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas fa = new Facturas();
            fa.MdiParent = this;
            fa.AutoSize = true;
            fa.Show();
            //TraducirForm(FI);
            fa.WindowState = FormWindowState.Maximized;
        }
    }
}
