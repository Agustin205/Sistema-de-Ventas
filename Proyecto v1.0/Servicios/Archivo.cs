using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Archivo
    {
        public string Nombre { get; set; }
        public string strPath { get; set; }
        public DateTime DateTime { get; set; }
        public DataTable pathArchivo()
        {
            string[] files = System.IO.Directory.GetFiles(@"C:\BackUp");
            DataTable dtUsuario = new DataTable("Usuario");
            dtUsuario.Columns.Add("Nombre", typeof(string));
            dtUsuario.Columns.Add("Path", typeof(string));
            dtUsuario.Columns.Add("DateTime", typeof(DateTime));
            foreach (string item in files)
            {
                dtUsuario.Rows.Add(Nombre = Path.GetFileName(item), strPath = item, DateTime = File.GetCreationTime(item));
            }
            return dtUsuario;
        }
    }
}
