using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class PermisoCompuesto : Permiso
    {
        List<Permiso> _l;

        List<Permiso> _laux;
        public PermisoCompuesto(string pCodigo) : base(pCodigo)
        {
            _l = new List<Permiso>();
        }
        public void AgregarPermiso(Permiso Ppermiso)
        {
            _l.Add(Ppermiso);
        }
        public List<Permiso> Retornacomponentes()
        {
            return _l;
        }
        public override List<Permiso> RetornaPermisos()
        {

            _laux = new List<Permiso>();
            RecursivaRetornaPermisos(_l);

            return _laux;
        }
        private void RecursivaRetornaPermisos(List<Permiso> pLista)
        {
            foreach (Permiso p in pLista)
            {
                if (p is PermisoSimple)
                {
                    _laux.Add(p);
                }
                else
                {
                    RecursivaRetornaPermisos((p as PermisoCompuesto).Retornacomponentes());
                }
            }

        }

    }
}
