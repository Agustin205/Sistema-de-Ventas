using ENTIDADES;
using MAPPERS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLIdioma
    {
        MPIdioma _MPI;
        public BLLIdioma()
        {

            _MPI = new MPIdioma();
        }
        public List<BEIdioma> RetornarLista()
        {
            return _MPI.RetornarLista();
        }

        public void AgregarIdioma(object[] pObject)
        {
            if (RetornarLista().Exists(x => x.NombreIdioma == pObject[0].ToString()))
            {
                System.Windows.Forms.MessageBox.Show("El idioma ya existe. Ingrese uno distinto");
            }
            else { _MPI.AgregarIdioma(pObject); System.Windows.Forms.MessageBox.Show("Se Agrego correctamente. Reinicie la aplicacion para aplicar los cambios"); }

        }

        public void BajaIdioma(string I)
        {
            _MPI.BajaIdioma(I);
        }

        public void BajaIdioma2(string I)
        {
            _MPI.BajaIdioma2(I);
        }
    }
}
