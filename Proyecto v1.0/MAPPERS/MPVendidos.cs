using DATOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPPERS
{
    public class MPVendidos
    {
        DAOVendidos dao;

        public MPVendidos() { dao = new DAOVendidos(); }
        public void BorrarPorImprimir()
        {
            dao.BorrarPorImprimir();
        }

        public DataTable DevolverProductosVendidos()
        {
            return dao.DevolverProductosVendidos();
        }

        public int CantidadUsuarios()
        {
            return dao.CantidadUsuarios();
        }
    }
}
