using ENTIDADES;
using MAPPERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLForm
    {
        MPForm _MPF;

        public BLLForm()
        {
            _MPF = new MPForm();
        }
        public List<BEForm> RetornarLista()
        {
            return _MPF.RetornarLista();
        }

        public void AgregarForm(object[] pObject)
        {
            _MPF.AgregarForm(pObject);
        }
        public BLLFormControl _bllFC;
        public BLLControl _bllC;

        public List<BEControl> RetornarControles(string pForm)
        {
            _bllFC = new BLLFormControl();
            _bllC = new BLLControl();
            List<BEControl> _aux = new List<BEControl>();
            foreach (BEFormControl FC in _bllFC.RetornarLista())
            {
                if (FC.Form.NombreForm == pForm)
                {
                    _aux.Add(_bllC.RetornarLista().Find(x => x.NombreControl == FC.Control.NombreControl));
                }
            }
            return _aux;
        }
        public void AgregarControlForm(object[] pObject)
        {
            _bllFC.AgregarFormControl(pObject);
        }
    }
}
