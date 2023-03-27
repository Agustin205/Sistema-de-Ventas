using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Servicios
{
    public class BackUp
    {
        daoUsuario Du = new daoUsuario();

        public string ElegirUbucacionBackUp(string ptextbox1)
        {
            FolderBrowserDialog FDB = new FolderBrowserDialog();
            if (FDB.ShowDialog() == DialogResult.OK)
            {
                ptextbox1 = FDB.SelectedPath;
            }

            return ptextbox1;
        }

        public void HacerBackUp(string ptextbox1)
        {
            Du.con = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
            if (ptextbox1 == string.Empty)
            {
                MessageBox.Show("La ubicacion no existe.");
            }
            string cmd = "BACKUP DATABASE Proyecto TO DISK = '" + ptextbox1 + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".bak'";
            Du.con.Open();
            SqlCommand command = new SqlCommand(cmd, Du.con);
            command.ExecuteNonQuery();
            MessageBox.Show("Backup creado con exito");
            Du.con.Close();
        }

        public string EncontrarUbicacion(string ptextbox2)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                ptextbox2 = OFD.FileName;
            }
            return ptextbox2;
        }

        public void restaurar(string ptextbox2)
        {
            Du.con = new SqlConnection("Data Source=.;Initial Catalog=Proyecto;Integrated Security=True");
            Du.con.Open();
            try
            {

                string str1 = string.Format("ALTER DATABASE Proyecto SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, Du.con);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE Proyecto FROM DISK = '" + ptextbox2 + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, Du.con);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE Proyecto SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, Du.con);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Backup restaurado con exito");

                Du.con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
