using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using Microsoft.VisualBasic;
using ENTIDADES;
using MAPPERS;
using Servicios;
using System.Windows.Forms;
using System.Data;

namespace BLL
{
    public class bllUsuario
    {
        mapper mp;
        public bllUsuario() { mp = new mapper(); }
        public int AltaUsuario(string pNombre, string pApellido, string pUsuarios, string pContraseña, string pDni, string pTelefono, string pEmail)
        {
            return mp.AltaUsuario(pNombre, pApellido, pUsuarios, pContraseña, pDni, pTelefono, pEmail);
        }

        public void BajaCuenta(string p)
        {
            mp.BajaCuenta(p);
        }

        public void ModUsuario(string user, string nuevo)
        {
            mp.ModUsuario(user, nuevo);
        }

        public int ValidarLoginUsuario(string pUsuario, string pContraseña, bool pEsEmail)
        {
            return mp.ValidarLoginUsuario(pUsuario, pContraseña, pEsEmail);
        }

        public void LoginValidado(Usuario user)
        {
            if (Singleton.Instancia.EstaLogeado())
                throw new Exception(MessageBox.Show("Ya esta logueado!").ToString());
            else
            {
                Singleton.Instancia.Login(user);
                MessageBox.Show("Usuario Logeado!");
            }


        }


        public void Logout()
        {
            Singleton.Instancia.Logout();

            if (Singleton.Instancia.EstaLogeado())
                throw new Exception(MessageBox.Show("Ya esta logueado!").ToString());
            else
                MessageBox.Show("Usuario Deslogueado!");
        }
        public Usuario RetornaUsuarioLogin(string usuario, string contraseña)
        {
            return mp.RetornaUsuarioLogin(usuario, contraseña);


        }
        public string RetornarID(string pUsuario, string pContraseña)
        {
            return mp.RetornarID(pUsuario, pContraseña);
        }


        public void IngresarRol(string pUsuario, string pRol)
        {
            mp.IngresarRol(pUsuario, pRol);
        }

        public void CambiarContraseña(string email, string contraseña)
        {
            mp.CambiarContraseña(email, contraseña);
        }

        public DataTable DevolverUsuarios()
        {
            return mp.DevolverUsuarios();
        }

       
        public List<string> CrearIdioma(string id, string idioma)
        {
            return mp.CrearIdioma(id, idioma);
        }
    }
}
