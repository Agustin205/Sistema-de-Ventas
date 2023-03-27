using System;


namespace ENTIDADES
{
    public class Sesion
    {
        public Usuario _usuarioS;

        public void Login(Usuario usuario)
        {
            _usuarioS = usuario;
        }
        public void Logout()
        {
            _usuarioS = null;
        }
        public bool EstaLogeado() { return _usuarioS != null; }
        /*
        public bool IsInRole(Enum tipoPermiso)
        {
            if (_usuarioS == null) return false;

            bool valid = false;
            foreach (var p in _usuarioS.Permisos)
            {
                if (p is Permiso && ((Permiso)p).ID.Equals(tipoPermiso))
                {
                    valid = true;
                }
                else
                {
                    valid = IsInRoleRecursivo(p, tipoPermiso, valid);
                }
            }

            return valid;
        }

        private bool IsInRoleRecursivo(Permiso p, Enum tipoPermiso, bool valid)
        {

            foreach (var item in p.ObtenerHijos())
            {
                if (item is Permiso && ((Permiso)item).ID.Equals(tipoPermiso))
                {
                    valid = true;
                }
                else
                {
                    valid = IsInRoleRecursivo(item, tipoPermiso, valid);
                }
            }
            return valid;
        }

        */
    }
}
