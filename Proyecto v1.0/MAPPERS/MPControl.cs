using DATOS;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAPPERS
{
    public class MPControl
    {
        DAOGeneral _dao;
        DAOControl _daoC;

        public MPControl()
        {

            _daoC = new DAOControl();
            _dao = _daoC.DaoU;
        }
        public List<BEControl> RetornarLista()
        {
            List<BEControl> Aux = new List<BEControl>();
            foreach (DataRow R in _dao.RetornarDS().Tables["Control"].Rows)
            {
                BEControl _C = new BEControl(R[0].ToString());
                Aux.Add(_C);
            }
            return Aux;
        }

        public void AgregarControl(object[] pObject)
        {
            _daoC.AgregarControl(pObject[0].ToString());
        }
    }
}
