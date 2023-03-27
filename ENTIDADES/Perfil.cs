using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Perfil
    {
        PermisoCompuesto _pc;
        public Perfil(PermisoCompuesto pCompuesto) { _pc = pCompuesto; }
        public bool Validar(string pCodigo)
        {
            return _pc.RetornaPermisos().Exists(x => x.Codigo == pCodigo);
        }
    }
}
