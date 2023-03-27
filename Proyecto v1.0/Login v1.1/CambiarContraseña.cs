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

namespace Login_v1._1
{
    public partial class CambiarContraseña : Form
    {
        bllUsuario bll;
        bllBitacora bllBitacora;
        VerificacionUser VF;
        public CambiarContraseña()
        {
            InitializeComponent();
            bll = new bllUsuario();
            bllBitacora = new bllBitacora();
            VF = new VerificacionUser();
        }

        private void btnRestablecer_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string contraseña1 = textBox2.Text;
            string contraseña2 = textBox3.Text;

            if (VF.VerificacionMail(email))
            {
                if (VF.VerificacionContraseña(contraseña1) && VF.VerificacionContraseña(contraseña2))
                {
                    if (contraseña1 == contraseña2)
                    {
                        bll.CambiarContraseña(email, Encriptacion.EncriptarConHash(contraseña2));
                        MessageBox.Show("La contraseña fue restablecida con exito");
                        DV.actualizarDV();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña no es la misma en los 2 campos");
                    }
                    bllBitacora.NuevaBitacora(email, "Restablecer Contraseña", 1, DateTime.Now);
                    this.Close();
                    LoginUser lu = new LoginUser();
                    lu.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña invalida");
                }
            }
            else
            {
                MessageBox.Show("Email invalido"); 
            }
            
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginUser lg = new LoginUser();
            lg.Show();
        }
    }
}
