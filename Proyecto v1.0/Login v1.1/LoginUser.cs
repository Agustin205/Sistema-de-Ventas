using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;
using BLL;
using Verificacion;
using Servicios;
using Microsoft.VisualBasic;

namespace Login_v1._1
{
    public partial class LoginUser : Form
    {
        List<Leyenda> _l;
        CambioIdioma _cambioIdioma;

        bllUsuario bll;
        bllBitacora bllBitacora;
        VerificacionUser ver;
        Encriptacion hash;
        BLLIdioma _bllI;
        BLLTraduccion _bllT;
        BLLForm _bllF;
        BLLControl _bllC;
        public LoginUser()
        {
            InitializeComponent();
            bll = new bllUsuario();
            bllBitacora = new bllBitacora();
            ver = new VerificacionUser();
            hash = new Encriptacion();
            _l = new List<Leyenda>();
            _cambioIdioma = new CambioIdioma(_l);
            _bllF = new BLLForm();
            _bllT = new BLLTraduccion();
            _bllI = new BLLIdioma();
            _bllC = new BLLControl();
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            Login();
        }
        int contador;
        public void Login()
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;
            bool esEmail;
            if(ver.VerificacionMail(usuario))
            {
                esEmail = true;
            }
            else
            {
                esEmail = false;
            }


            if (bll.ValidarLoginUsuario(usuario, Encriptacion.EncriptarConHash(contraseña), esEmail) > 0)
            {
                bll.LoginValidado(bll.RetornaUsuarioLogin(usuario, Encriptacion.EncriptarConHash(contraseña)));


                if (bll.RetornarID(usuario, Encriptacion.EncriptarConHash(contraseña)) == "PC002")
                {
                    MainMenu main = new MainMenu();
                    main.idioma = _cambioIdioma.Idioma;
                    main.ValidarForm();
                    main.Show();
                }
                else
                {
                    MainMenu main = new MainMenu();
                    main.IdiomaSeleccionado = comboBox1.SelectedValue.ToString();
                    main.ValidarForm();
                    main.Show();
                    main.WindowState = FormWindowState.Maximized;
                }

                this.Hide();
                
            }
            else
            {
                contador++;
                MessageBox.Show("ERROR EN LOS DATOS");

                if (ver.IntentosFallidos(contador))
                {
                    MessageBox.Show("Fallaste mas de 3 veces, intenta mas tarde!");
                    IniciarSesion.Visible = false;
                    bllBitacora.NuevaBitacora("", "3 intentos de logeo fallidos", 2, DateTime.Now);
                }
            }

            bllBitacora.NuevaBitacora(usuario, IniciarSesion.Text, 1, DateTime.Now);
        }

        

        private void Registrarse_Click(object sender, EventArgs e)
        {
            RegistrarUser RU = new RegistrarUser();
            RU.Show();
            TraducirForm(RU);
        }

        private void LoginUser_Load(object sender, EventArgs e)
        {
            if (!DV.verificarDV())
            {
                MessageBox.Show("ERRROR DV");
                labelTitulo.Visible = false;
                lblUser.Visible = false;
                Contraseña.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                linkOlvideContraseña.Visible = false;
                IniciarSesion.Visible = false;
                Registrarse.Visible = false;
                labelErr.Visible = true;
                BackUp.Visible = true;
                ActualizarDV.Visible = true;
                bllBitacora.NuevaBitacora("", "Crash en DV", 5, DateTime.Now);
            }
            //Idioma();
            foreach (Control C in this.Controls)
            {
                if (C.Text != null && C.Text != "")
                {
                    if (!_bllF.RetornarLista().Exists(x => x.NombreForm == this.Name))
                    {
                        _bllF.AgregarForm(new object[] { this.Name });
                    }
                    if (!_bllC.RetornarLista().Exists(x => x.NombreControl == C.Name))
                    {
                        _bllC.AgregarControl(new object[] { C.Name });
                    }
                    if (!_bllF.RetornarControles(this.Name).Exists(x => x.NombreControl == C.Name))
                    {
                        _bllF.AgregarControlForm(new object[] { this.Name, C.Name });

                    }

                    if (!_bllT.RetornarLista().Exists(x => x.Idioma.NombreIdioma == "Español" && x.Form.NombreForm == this.Name && x.Control.NombreControl == C.Name))
                    {
                        _bllT.AgregarTraduccion(new object[] { "Español", this.Name.ToString(), C.Name, C.Text });
                    }
                }
            }

            foreach (BEControl C in _bllF.RetornarControles(this.Name.ToString()))
            {
                foreach (Control _c in this.Controls)
                {
                    if (_c.Name == C.NombreControl)
                    {
                        _c.Text = _bllT.Traducir("Español", this.Name.ToString(), C.NombreControl);
                    }
                }
            }
            comboBox1.DataSource = _bllI.RetornarLista();
            comboBox1.DisplayMember = "NombreIdioma";
            comboBox1.ValueMember = "NombreIdioma";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.SelectedValue = "Español";
            BEIdioma.IdiomaSeleccionado = "Español";
        }

        public void Idioma()
        {
            Leyenda l1 = new Leyenda() { id = "l1" };
            Leyenda l2 = new Leyenda() { id = "l2" };
            Leyenda l3 = new Leyenda() { id = "l3" };
            Leyenda l4 = new Leyenda() { id = "l4" };
            Leyenda b1 = new Leyenda() { id = "b1" };
            Leyenda b2 = new Leyenda() { id = "b2" };


            List<string> listaL1 = new List<string>(bll.CrearIdioma("l1", "eng"));
            l1.AgregarIdioma(listaL1[0], listaL1[1]);

            List<string> listaL2 = new List<string>(bll.CrearIdioma("l2", "eng"));
            l2.AgregarIdioma(listaL2[0], listaL2[1]);

            List<string> listaL3 = new List<string>(bll.CrearIdioma("l3", "eng"));
            l3.AgregarIdioma(listaL3[0], listaL3[1]);

            List<string> listaL4 = new List<string>(bll.CrearIdioma("l4", "eng"));
            l4.AgregarIdioma(listaL4[0], listaL4[1]);

            List<string> listab1 = new List<string>(bll.CrearIdioma("b1", "eng"));
            b1.AgregarIdioma(listab1[0], listab1[1]);

            List<string> listab2 = new List<string>(bll.CrearIdioma("b2", "eng"));
            b2.AgregarIdioma(listab2[0], listab2[1]);

            List<string> listaL12 = new List<string>(bll.CrearIdioma("l1", "esp"));
            l1.AgregarIdioma(listaL12[0], listaL12[1]);

            List<string> listaL22 = new List<string>(bll.CrearIdioma("l2", "esp"));
            l2.AgregarIdioma(listaL22[0], listaL22[1]);

            List<string> listaL32 = new List<string>(bll.CrearIdioma("l3", "esp"));
            l3.AgregarIdioma(listaL32[0], listaL32[1]);

            List<string> listaL42 = new List<string>(bll.CrearIdioma("l4", "esp"));
            l4.AgregarIdioma(listaL42[0], listaL42[1]);

            List<string> listab12 = new List<string>(bll.CrearIdioma("b1", "esp"));
            b1.AgregarIdioma(listab12[0], listab12[1]);

            List<string> listab22 = new List<string>(bll.CrearIdioma("b2", "esp"));
            b2.AgregarIdioma(listab22[0], listab22[1]);

            _l.AddRange(new Leyenda[] { l1, l2, l3, l4, b1, b2 });


            _cambioIdioma.Idioma = "esp";





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
        private void linkOlvideContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarContraseña cPass = new CambiarContraseña();
            TraducirForm(cPass);
            cPass.Show();

            this.Hide();
        }


        private void BackUp_Click(object sender, EventArgs e)
        {
            BackUp BU = new BackUp();
            string a = "Agustin";
            string b = Interaction.InputBox("Establezca la contraseña que solo los administradores saben para acceder: ");
            if (b == a)
            {
                BU.Show();
            }
            else { MessageBox.Show("Contraseña Incorrecta, vuelva a intentar"); }
        }

        private void ActualizarDV_Click(object sender, EventArgs e)
        {
            string a = "Agustin";
            string b = Interaction.InputBox("Establezca la contraseña que solo los administradores saben para acceder: ");
            if (b == a)
            {
                DV.actualizarDV();
                this.Hide();
                LoginUser lu = new LoginUser();
                lu.Show();
            }
            else { MessageBox.Show("Contraseña Incorrecta, vuelva a intentar"); }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BEIdioma.IdiomaSeleccionado = comboBox1.SelectedValue.ToString();
            foreach (BEControl C in _bllF.RetornarControles(this.Name.ToString()))
            {
                foreach (Control _c in this.Controls)
                {
                    if (_c.Name == C.NombreControl)
                    {
                        _c.Text = _bllT.Traducir(comboBox1.SelectedValue.ToString(), this.Name.ToString(), C.NombreControl);
                    }
                }
            }
        }
    }
}
