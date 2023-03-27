using MAPPERS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCompras
    {
        MPCompras mp;

        public BLLCompras()
        {
            mp = new MPCompras();
        }

        public DataTable DevolverVendidos(string id)
        {
            return mp.DevolverVendidos(id);
        }

        public DataTable DevolverFacturas()
        {
            return mp.DevolverFacturas();
        }
    }
}
