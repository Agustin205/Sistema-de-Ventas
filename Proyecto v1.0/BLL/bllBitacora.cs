using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using ENTIDADES;
using MAPPERS;
using Servicios;

namespace BLL
{
    public class bllBitacora
    {
        mapper mp;
        public bllBitacora() { mp = new mapper(); }
        public void NuevaBitacora(string usuario, string accion, int severidad, DateTime fecha)
        {
            mp.NuevaBitacora(usuario, accion, severidad, fecha);
        }
    }
}
