using MAPPERS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLVendidos
    {
        MPVendidos mp;

        public BLLVendidos() { mp = new MPVendidos(); }
        public void BorrarPorImprimir()
        {
            mp.BorrarPorImprimir();
        }
        public DataTable DevolverProductosVendidos()
        {
            return mp.DevolverProductosVendidos();
        }
        public int CantidadUsuarios()
        {
            return mp.CantidadUsuarios();
        }
    }
}
