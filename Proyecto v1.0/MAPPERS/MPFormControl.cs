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
    public class MPFormControl
    {
        DAOGeneral _dao;
        DAOFormControl _daoFC;
        public MPFormControl()
        {
            _daoFC = new DAOFormControl();
            _dao = _daoFC.DaoU;
        }
        public List<BEFormControl> RetornarLista()
        {
            List<BEFormControl> Aux = new List<BEFormControl>();
            foreach (DataRow R in _dao.RetornarDS().Tables["[Form-Control]"].Rows)
            {
                BEFormControl _FC = new BEFormControl(new BEForm(R[0].ToString()), new BEControl(R[1].ToString()));
                Aux.Add(_FC);
            }
            return Aux;
        }
        public void AgregarFormControl(object[] pObject)
        {
            _daoFC.AgregarFormControl(pObject[0].ToString(), pObject[1].ToString());
        }

    }
}
