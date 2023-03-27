using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;

namespace Servicios
{
    public class Singleton
    {
        private static Sesion _instancia;
        public static Sesion Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Sesion();
                }
                return _instancia;
            }
        }
    }
}
