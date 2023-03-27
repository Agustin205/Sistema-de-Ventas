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
using BLL;
using ENTIDADES;
using Verificacion;

namespace Login_v1._1
{
    public partial class RegistrarUser : Form
    {
        bllUsuario bll;
        bllBitacora bllBitacora;
        VerificacionUser ver;
        public RegistrarUser()
        {
            InitializeComponent();
            bll = new bllUsuario();
            bllBitacora = new bllBitacora();
            ver = new VerificacionUser();
        }

        private void RegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (ver.VerificacionUsuario(textUsuario.Text))
                {
                    if (ver.VerificacionMail(txtEmail.Text))
                    {
                        if (ver.VerificacionContraseña(textContraseña.Text))
                        {
                            if (bll.AltaUsuario(textNombre.Text, textApellido.Text, textUsuario.Text, Encriptacion.EncriptarConHash(textContraseña.Text), textDni.Text, textTelefono.Text, txtEmail.Text) > 0)
                            {
                                DV.actualizarDV();
                                MessageBox.Show("Cuenta creada Con EXITO!!!!");

                                LoginUser LU = new LoginUser();
                                LU.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("ERROR EN LOS DATOS");
                            }
                        }
                        else
                        {
                            MessageBox.Show("ERROR EN LA CONTRASEÑA");
                        }
                    }
                    else
                    {
                        MessageBox.Show("ERROR EN EL MAIL");
                    }
                }
                else
                {
                    MessageBox.Show("EL NICK NO CUMPLE CON LAS POLITICAS");
                }

                bllBitacora.NuevaBitacora(textUsuario.Text, "Registro", 2, DateTime.Now);
            }
            catch (Exception) { MessageBox.Show("Error"); }
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
