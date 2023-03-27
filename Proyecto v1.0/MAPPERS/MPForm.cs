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
    public class MPForm
    {
        DAOGeneral _dao;
        DAOForm _daoF;

        public MPForm()
        {
            _daoF = new DAOForm();
            _dao = _daoF.DaoU;
        }
        public List<BEForm> RetornarLista()
        {
            List<BEForm> Aux = new List<BEForm>();
            foreach (DataRow R in _dao.RetornarDS().Tables["Form"].Rows)
            {
                BEForm _F = new BEForm(R[0].ToString());
                Aux.Add(_F);
            }
            return Aux;
        }

        public void AgregarForm(object[] pObject)
        {
            _daoF.AgregarForm(pObject[0].ToString());
        }

    }
}
