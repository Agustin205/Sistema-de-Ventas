using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAPPERS
{
    public class MPPermisos 
    {
        DAOPermisos dao;

        public MPPermisos()
        {
            dao = new DAOPermisos();
        }
        public List<string> PermisosUsuario(Usuario pUsuario)
        {
            return dao.PermisosUsuario(pUsuario);
        }

        public List<string> PermisosUsuarioID(string usuario, string idPC)
        {
            return dao.PermisosUsuarioID(usuario, idPC);
        }
        public List<string> TodosLosPermisos()
        {
            return dao.TodosLosPermisos();
        }

        public int AltaPermiso(string PC, string PS)
        {
            return dao.InsertarPermisos(PC, PS);
        }

        public int AltaPermisoEnID(string PC)
        {
            return dao.InsertarEnPermisosID(PC);
        }

        public int BajaPermiso(string PC)
        {
            return dao.BorrarPermisos(PC);
        }

        public int BajaPermisoEnID(string PC)
        {
            return dao.BorrarPermisosEnID(PC);
        }

        public int ModificarPermisos(string PC, string PS)
        {
            return dao.ModificarPermisos(PC, PS);
        }

        public int ModiificarPermisosPersonas(String usuario, string PC)
        {
            return dao.ModificarPermisosPersona(usuario, PC);
        }

        public void ModificarNull(string PC, string A)
        {
            dao.ModificarNull(PC, A);
        }

        public void LlenarCombo(ComboBox cb)
        {
            dao.LlenarCombo(cb);
        }
    }
}
