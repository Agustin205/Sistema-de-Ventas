using ENTIDADES;
using MAPPERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTraduccion
    {

        MPTraduccion _MPT;
        public BLLTraduccion()
        {
            _MPT = new MPTraduccion();
        }
        BLLForm _bllForm;
        BLLIdioma _bllIdioma;
        BLLControl _bllControl;
        public List<BETraduccion> RetornarLista()
        {
            _bllForm = new BLLForm();
            _bllIdioma = new BLLIdioma();
            _bllControl = new BLLControl();
            List<BETraduccion> Aux = new List<BETraduccion>();
            foreach (BETraduccion T in _MPT.RetornarLista())
            {
                BEForm F = _bllForm.RetornarLista().Find(x => x.NombreForm == T.Form.NombreForm);
                BEIdioma I = _bllIdioma.RetornarLista().Find(x => x.NombreIdioma == T.Idioma.NombreIdioma);
                BEControl C = _bllControl.RetornarLista().Find(x => x.NombreControl == T.Control.NombreControl);
                T.Form = F;
                T.Control = C;
                T.Idioma = I;
                Aux.Add(T);
            }
            return Aux;
        }
        public void AgregarTraduccion(object[] pObject)
        {
            bool modificar = RetornarLista().Exists(x => x.Idioma.NombreIdioma == pObject[0].ToString() && x.Form.NombreForm == pObject[1].ToString() && x.Control.NombreControl == pObject[2].ToString());
            if (modificar)
            {
                Modificar(pObject);
            }
            else
            {
                _MPT.AgregarTraduccion(pObject);
            }
            RetornarLista();
        }
        public void Modificar(object[] pObject)
        {
            _MPT.ModificarTraduccion(pObject);

        }
        public string Traducir(string pIdioma, string pForm, string pControl)
        {
            string rta = "Sin Traducir";
            if (RetornarLista().Exists(x => x.Idioma.NombreIdioma == pIdioma && x.Form.NombreForm == pForm && x.Control.NombreControl == pControl))
            {
                rta = RetornarLista().Find(x => x.Idioma.NombreIdioma == pIdioma && x.Form.NombreForm == pForm && x.Control.NombreControl == pControl).Traduccion;
            }
            return rta;
        }
    }
}
