using ENTIDADES;
using MAPPERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class BLLPermisos
    {
        MPPermisos mp;

        public BLLPermisos() { mp = new MPPermisos(); }
        public List<string> PermisosUsuario(Usuario pUsuario)
        {
            return mp.PermisosUsuario(pUsuario);
        }

        public List<string> PermisosUsuarioID(string usuario, string idPC)
        {
            return mp.PermisosUsuarioID(usuario, idPC);
        }
        public List<string> TodosLosPermisos()
        {
            return mp.TodosLosPermisos();
        }

        public int InsertarPermisos(string PC, string PS)
        {
            return mp.AltaPermiso(PC, PS);
        }

        public int InsertarPermisosEnID(string PC)
        {
            return mp.AltaPermisoEnID(PC);
        }

        public int BorrarPermiso(string PC)
        {
            return mp.BajaPermiso(PC);
        }

        public int BajaPermisoEnID(string PC)
        {
            return mp.BajaPermisoEnID(PC);
        }

        public int ModificarPermisos(string PC, string PS)
        {
            return mp.ModificarPermisos(PC, PS);
        }

        public int ModiificarPermisosPersonas(String usuario, string PC)
        {
            return mp.ModiificarPermisosPersonas(usuario, PC);
        }

        public void ModificarNull(string PC, string A)
        {
            mp.ModificarNull(PC, A);
        }

        public void LlenarCombo(ComboBox cb)
        {
            mp.LlenarCombo(cb);
        }
    }
}
