using DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPERS
{
    public class MPCompras
    {
        DAOCompras dao;

        public MPCompras()
        {
            dao = new DAOCompras();
        }
        public DataTable DevolverVendidos(string id)
        {
            return dao.DevolverVendidos(id);
        }

        public DataTable DevolverFacturas()
        {
            return dao.DevolverFacturas();
        }
    }
}
