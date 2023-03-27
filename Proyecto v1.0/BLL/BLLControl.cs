using ENTIDADES;
using MAPPERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLControl
    {
        MPControl _MPC;
        public BLLControl()
        {

            _MPC = new MPControl();
        }
        public List<BEControl> RetornarLista()
        {
            return _MPC.RetornarLista();
        }

        public void AgregarControl(object[] pObject)
        {
            _MPC.AgregarControl(pObject);
        }
    }
}
