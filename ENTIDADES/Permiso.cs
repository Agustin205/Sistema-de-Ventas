using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public abstract class Permiso
    {
        string _codigo;
        public Permiso(string pCodigo)
        {
            _codigo = pCodigo;
        }
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public abstract List<Permiso> RetornaPermisos();
    }
}
