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
    public class MPIdioma
    {
        DAOGeneral _dao;
        DAOIdioma _daoI;

        public MPIdioma()
        {

            _daoI = new DAOIdioma();
            _dao = _daoI.DaoU;
        }
        public List<BEIdioma> RetornarLista()
        {
            List<BEIdioma> Aux = new List<BEIdioma>();
            foreach (DataRow R in _dao.RetornarDS().Tables["Idioma"].Rows)
            {
                BEIdioma _I = new BEIdioma(R[0].ToString());
                Aux.Add(_I);
            }
            return Aux;
        }

        public void AgregarIdioma(object[] pObject)
        {
            _daoI.AgregarIdioma(pObject[0].ToString());
        }

        public void BajaIdioma(string I)
        {
            _daoI.BajaIdioma(I);
        }

        public void BajaIdioma2(string I)
        {
            _daoI.BajaIdioma2(I);
        }
    }
}
