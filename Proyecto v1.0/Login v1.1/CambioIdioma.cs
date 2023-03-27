using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace Login_v1._1
{
    public class CambioIdioma
    {
        List<Leyenda> listaLeyendas;
        List<Control> listaControles;
        private string _idioma;
        public CambioIdioma(List<Leyenda> listaLe)
        {
            listaLeyendas = listaLe;
            listaControles = new List<Control>();
        }
        public string Idioma
        {
            get { return _idioma; }
            set { _idioma = value; Notificacion(); }
        }
        public void AgregarObservador(Control pButton) { listaControles.Add(pButton); }
        private void Notificacion()
        {
            foreach (Control b in listaControles)
            {
                if (b is UserControlBotones)
                {
                    (b as UserControlBotones).CambioDeIdioma(listaLeyendas, Idioma);
                }
                if (b is UserControlLabel)
                {
                    (b as UserControlLabel).CambioDeIdioma(listaLeyendas, Idioma);
                }
            }
        }



    }
}
