using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPERS
{
    public class MPTraduccion
    {
        DAOGeneral _dao;
        DAOTraduccion _daoT;
        public MPTraduccion()
        {
            _daoT = new DAOTraduccion();
            _dao = _daoT.DaoU;
        }
        public List<BETraduccion> RetornarLista()
        {
            List<BETraduccion> Aux = new List<BETraduccion>();
            foreach (DataRow R in _dao.RetornarDS().Tables["Traduccion"].Rows)
            {
                BETraduccion _T = new BETraduccion(new BEIdioma(R[0].ToString()), new BEForm(R[1].ToString()), new BEControl(R[2].ToString()), R[3].ToString());
                Aux.Add(_T);
            }
            return Aux;
        }
        public void AgregarTraduccion(object[] pObject)
        {
            _daoT.AgregarTraduccion(pObject[0].ToString(), pObject[1].ToString(), pObject[2].ToString(), pObject[3].ToString());
        }
        public void ModificarTraduccion(object[] pObject)
        {
            _daoT.ModificarTraduccion(pObject[0].ToString(), pObject[1].ToString(), pObject[2].ToString(), pObject[3].ToString());
        }
    }
}
