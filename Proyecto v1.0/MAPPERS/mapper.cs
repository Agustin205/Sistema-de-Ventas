using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDADES;
using Microsoft.VisualBasic;
using System.Data;
using System.Windows.Forms;

namespace MAPPERS
{
    public class mapper
    {
        DataSet ds;
        daoUsuario dao;
        public mapper()
        {
            dao = new daoUsuario();
            ds = dao.RetornaDS();
        }

        public int AltaUsuario(string pNombre, string pApellido, string pUsuarios, string pContraseña, string pDni, string pTelefono, string pEmail)
        {
            return dao.CrearCuenta(pNombre, pApellido, pUsuarios, pContraseña, pDni, pTelefono, pEmail);
        }
       
        public void BajaCuenta(string p)
        {
            dao.BajaCuenta(p);
        }
        

        public void ModUsuario(string user, string nuevo)
        {
            dao.ModificarUsuario(user, nuevo);
        }
       

        public int ValidarLoginUsuario(string pUsuario,string pContraseña, bool pEsEmail)
        {
           return dao.Autentificar(pUsuario,pContraseña, pEsEmail);
        }
        public void IngresarRol(string pUsuario, string pRol)
        {
            dao.IngresarRol(pUsuario, pRol);
        }
        public string RetornarID(string pUsuario, string pContraseña)
        {
            return dao.retornarID(pUsuario, pContraseña);
        }
        public Usuario RetornaUsuarioLogin(string usuario, string contraseña)
        {
            return dao.RetornaUsuarioLogin(usuario, contraseña);
        }

        public void NuevaBitacora(string usuario, string accion, int severidad, DateTime fecha)
        {
            dao.NuevaBitacora(usuario, accion, severidad, fecha);
        }

        public void CambiarContraseña(string email, string contraseña)
        {
            dao.CambiarContraseña(email, contraseña);
        }
        public DataTable DevolverUsuarios()
        {
            return dao.DevolverUsuarios();
        }

        public List<string> CrearIdioma(string id, string idioma)
        {
            return dao.CrearIdioma(id, idioma);
        }
    }
}
