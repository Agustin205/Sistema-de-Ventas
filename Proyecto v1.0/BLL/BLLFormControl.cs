using ENTIDADES;
using MAPPERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFormControl
    {
        MPFormControl _MPFC;
        public BLLFormControl()
        {
            _MPFC = new MPFormControl();
        }
        BLLForm _bllForm;
        BLLControl _bllControl;
        public List<BEFormControl> RetornarLista()
        {
            _bllForm = new BLLForm();
            _bllControl = new BLLControl();
            List<BEFormControl> _aux = new List<BEFormControl>();
            foreach (BEFormControl FC in _MPFC.RetornarLista())
            {
                BEForm F = _bllForm.RetornarLista().Find(x => x.NombreForm == FC.Form.NombreForm);
                BEControl C = _bllControl.RetornarLista().Find(x => x.NombreControl == FC.Control.NombreControl);
                FC.Form = F;
                FC.Control = C;
                _aux.Add(FC);
            }
            return _aux;
        }
        public void AgregarFormControl(object[] pObject)
        {
            _MPFC.AgregarFormControl(pObject);
        }

    }
}
