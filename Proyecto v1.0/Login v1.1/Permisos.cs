using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTIDADES;
using Microsoft.VisualBasic;
using Servicios;

namespace Login_v1._1
{
    public partial class Permisos : Form
    {
        bllUsuario bll;
        BLLPermisos bllp;
        List<Leyenda> _l;
        CambioIdioma _cambioIdioma;
        bllBitacora bllBitacora;
        public string idioma;
        public Permisos()
        {
            InitializeComponent();
            bll = new bllUsuario();
            bllp = new BLLPermisos();
            _l = new List<Leyenda>();
            bllBitacora = new bllBitacora();
            _cambioIdioma = new CambioIdioma(_l);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Idioma();
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarUsuarios();
            bllp.LlenarCombo(comboBox1);
        }

        public TreeNode Nodo2(List<string> listaPermisos)
        {
            TreeNode _aux = new TreeNode(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            foreach (string x in listaPermisos)
            {
                _aux.Nodes.Add(x);
            }
            return _aux;
        }
        public void Mostrar(object pObject)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pObject;
        }
        public void MostrarUsuarios()
        {
            Mostrar(bll.DevolverUsuarios());

        }

        private void Ver_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(Nodo2(bllp.PermisosUsuarioID(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[3].Value.ToString())));
                treeView1.ExpandAll();
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Permisos Mostrados", 3, DateTime.Now);
            }
            catch (Exception) { MessageBox.Show("Hubo un error"); }
        }

        private void CrearPermisoCompuesto_Click(object sender, EventArgs e)
        {
            string nombre = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string A = textBox1.Text;
            if (checkBox1.Checked)
            {
                if(bllp.InsertarPermisos(A, "Administracion") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Administración");
                }
            }
            if (checkBox2.Checked)
            {
                if (bllp.InsertarPermisos(A, "Negocio") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Negocio");
                }
            }
            if (checkBox3.Checked)
            {
                if (bllp.InsertarPermisos(A, "Desloguearse") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Desloguearse");
                }
            }
            if (checkBox4.Checked)
            {
                if (bllp.InsertarPermisos(A, "Perfiles") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Perfiles");
                }
            }
            if (checkBox5.Checked)
            {
                if (bllp.InsertarPermisos(A, "Bitacora") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Bitacora");
                }
            }
            if (checkBox6.Checked)
            {
                if (bllp.InsertarPermisos(A, "ControlCambios") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS ControlCambios");
                }
            }
            if (checkBox7.Checked)
            {
                if (bllp.InsertarPermisos(A, "BackUp") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS BackUp");
                }
            }
            if (checkBox8.Checked)
            {
                if (bllp.InsertarPermisos(A, "Productos") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Productos");
                }
            }
            if (checkBox9.Checked)
            {
                if (bllp.InsertarPermisos(A, "Vendidos") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Vendidos");
                }
            }
            if (checkBox10.Checked)
            {
                if (bllp.InsertarPermisos(A, "MultiIdioma") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS MultiIdioma");
                }
            }
            if (checkBox11.Checked)
            {
                if (bllp.InsertarPermisos(A, "Comprar") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Comprar");
                }
            }
            if (checkBox12.Checked)
            {
                if (bllp.InsertarPermisos(A, "Facturas") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Facturas");
                }
            }
            bllp.InsertarPermisosEnID(A);
            comboBox1.Items.Clear();
            bllp.LlenarCombo(comboBox1);
            DV.actualizarDV();
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Perfil creado", 4, DateTime.Now);
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Un Perfil ha sido asignado", 4, DateTime.Now);
        }

        private void BorrarPermisos_Click(object sender, EventArgs e)
        {
            string nombre = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string A = comboBox1.Text;
            bllp.BajaPermisoEnID(A);
            if (bllp.BorrarPermiso(A) > 0)
            {
                MessageBox.Show("Borrado");
                bllp.ModificarNull("Empleado2",A);
                comboBox1.Items.Clear();
                comboBox1.Text = "Administrador";
                bllp.LlenarCombo(comboBox1);
                DV.actualizarDV();
            }
            MostrarUsuarios();
            DV.actualizarDV();
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Un Perfil ah sido borrado", 5, DateTime.Now);
        }

        private void ModificarPermiso_Click(object sender, EventArgs e)
        {
            string nombre = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            string A = comboBox1.Text;
            bllp.BorrarPermiso(A);
            if (checkBox1.Checked)
            {
                if (bllp.InsertarPermisos(A, "Administracion") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Administracion");
                }
            }
            if (checkBox2.Checked)
            {
                if (bllp.InsertarPermisos(A, "Negocio") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Negocio");
                }
            }
            if (checkBox3.Checked)
            {
                if (bllp.InsertarPermisos(A, "Desloguearse") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Desloguearse");
                }
            }
            if (checkBox4.Checked)
            {
                if (bllp.InsertarPermisos(A, "Perfiles") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Perfiles");
                }
            }
            if (checkBox5.Checked)
            {
                if (bllp.InsertarPermisos(A, "Bitacora") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Bitacora");
                }
            }
            if (checkBox6.Checked)
            {
                if (bllp.InsertarPermisos(A, "ControlCambios") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS ControlCambios");
                }
            }
            if(checkBox7.Checked)
            {
                if (bllp.InsertarPermisos(A, "BackUp") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS BackUp");
                }
            }
            if (checkBox8.Checked)
            {
                if (bllp.InsertarPermisos(A, "Productos") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Productos");
                }
            }
            if (checkBox9.Checked)
            {
                if (bllp.InsertarPermisos(A, "Vendidos") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Vendidos");
                }
            }
            if (checkBox10.Checked)
            {
                if (bllp.InsertarPermisos(A, "MultiIdioma") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS MultiIdioma");
                }
            }
            if (checkBox11.Checked)
            {
                if (bllp.InsertarPermisos(A, "Comprar") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Comprar");
                }
            }
            if (checkBox12.Checked)
            {
                if (bllp.InsertarPermisos(A, "Facturas") > 0)
                {
                    MessageBox.Show($"En el PC '{A}' ha sido insetado el PS Facturas");
                }
            }
                    DV.actualizarDV();
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Un Perfil ha sido modificado", 5, DateTime.Now);
        }

        private void AsignarCompuesto_Click(object sender, EventArgs e)
        {
            string nombre = (dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            bllp.ModiificarPermisosPersonas(nombre, comboBox1.Text);
            DV.actualizarDV();
            MessageBox.Show("Asignado");
            MostrarUsuarios();
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Un Perfil ha sido asignado", 4, DateTime.Now);
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        public void Idioma()
        {
            Leyenda b9 = new Leyenda() { id = "b9" };
            Leyenda b10 = new Leyenda() { id = "b10" };
            Leyenda b11 = new Leyenda() { id = "b11" };
            Leyenda b12 = new Leyenda() { id = "b12" };
            Leyenda b13 = new Leyenda() { id = "b13" };
            Leyenda b14 = new Leyenda() { id = "b14" };
            Leyenda l6 = new Leyenda() { id = "l6" };
            Leyenda l7 = new Leyenda() { id = "l7" };
            Leyenda l8 = new Leyenda() { id = "l8" };
            Leyenda l9 = new Leyenda() { id = "l9" };
            Leyenda l10 = new Leyenda() { id = "l10" };
            Leyenda l11 = new Leyenda() { id = "l11" };
            Leyenda l12 = new Leyenda() { id = "l12" };
            Leyenda l13 = new Leyenda() { id = "l13" };
            Leyenda l14 = new Leyenda() { id = "l14" };

            List<string> listab9 = new List<string>(bll.CrearIdioma("b9", "eng"));
            b9.AgregarIdioma(listab9[0], listab9[1]);

            List<string> listab10 = new List<string>(bll.CrearIdioma("b10", "eng"));
            b10.AgregarIdioma(listab10[0], listab10[1]);

            List<string> listab11 = new List<string>(bll.CrearIdioma("b11", "eng"));
            b11.AgregarIdioma(listab11[0], listab11[1]);

            List<string> listab12 = new List<string>(bll.CrearIdioma("b12", "eng"));
            b12.AgregarIdioma(listab12[0], listab12[1]);

            List<string> listab13 = new List<string>(bll.CrearIdioma("b13", "eng"));
            b13.AgregarIdioma(listab13[0], listab13[1]);

            List<string> listab14 = new List<string>(bll.CrearIdioma("b14", "eng"));
            b14.AgregarIdioma(listab14[0], listab14[1]);

            List<string> listal6 = new List<string>(bll.CrearIdioma("l6", "eng"));
            l6.AgregarIdioma(listal6[0], listal6[1]);

            List<string> listal7 = new List<string>(bll.CrearIdioma("l7", "eng"));
            l7.AgregarIdioma(listal7[0], listal7[1]);

            List<string> listal8 = new List<string>(bll.CrearIdioma("l8", "eng"));
            l8.AgregarIdioma(listal8[0], listal8[1]);

            List<string> listal9 = new List<string>(bll.CrearIdioma("l9", "eng"));
            l9.AgregarIdioma(listal9[0], listal9[1]);

            List<string> listal10 = new List<string>(bll.CrearIdioma("l10", "eng"));
            l10.AgregarIdioma(listal10[0], listal10[1]);

            List<string> listal11 = new List<string>(bll.CrearIdioma("l11", "eng"));
            l11.AgregarIdioma(listal11[0], listal11[1]);

            List<string> listal12 = new List<string>(bll.CrearIdioma("l12", "eng"));
            l12.AgregarIdioma(listal12[0], listal12[1]);

            List<string> listal13 = new List<string>(bll.CrearIdioma("l13", "eng"));
            l13.AgregarIdioma(listal13[0], listal13[1]);

            List<string> listal14 = new List<string>(bll.CrearIdioma("l14", "eng"));
            l14.AgregarIdioma(listal14[0], listal14[1]);

            List<string> listab92 = new List<string>(bll.CrearIdioma("b9", "esp"));
            b9.AgregarIdioma(listab92[0], listab92[1]);

            List<string> listab102 = new List<string>(bll.CrearIdioma("b10", "esp"));
            b10.AgregarIdioma(listab102[0], listab102[1]);

            List<string> listab112 = new List<string>(bll.CrearIdioma("b11", "esp"));
            b11.AgregarIdioma(listab112[0], listab112[1]);

            List<string> listab122 = new List<string>(bll.CrearIdioma("b12", "esp"));
            b12.AgregarIdioma(listab122[0], listab122[1]);

            List<string> listab132 = new List<string>(bll.CrearIdioma("b13", "esp"));
            b13.AgregarIdioma(listab132[0], listab132[1]);

            List<string> listab142 = new List<string>(bll.CrearIdioma("b14", "esp"));
            b14.AgregarIdioma(listab142[0], listab142[1]);

            List<string> listal61 = new List<string>(bll.CrearIdioma("l6", "esp"));
            l6.AgregarIdioma(listal61[0], listal61[1]);

            List<string> listal71 = new List<string>(bll.CrearIdioma("l7", "esp"));
            l7.AgregarIdioma(listal71[0], listal71[1]);

            List<string> listal81 = new List<string>(bll.CrearIdioma("l8", "esp"));
            l8.AgregarIdioma(listal81[0], listal81[1]);

            List<string> listal91 = new List<string>(bll.CrearIdioma("l9", "esp"));
            l9.AgregarIdioma(listal91[0], listal91[1]);

            List<string> listal101 = new List<string>(bll.CrearIdioma("l10", "esp"));
            l10.AgregarIdioma(listal101[0], listal101[1]);

            List<string> listal111 = new List<string>(bll.CrearIdioma("l11", "esp"));
            l11.AgregarIdioma(listal111[0], listal111[1]);

            List<string> listal121 = new List<string>(bll.CrearIdioma("l12", "esp"));
            l12.AgregarIdioma(listal121[0], listal121[1]);

            List<string> listal131 = new List<string>(bll.CrearIdioma("l13", "esp"));
            l13.AgregarIdioma(listal131[0], listal131[1]);

            List<string> listal141 = new List<string>(bll.CrearIdioma("l14", "esp"));
            l14.AgregarIdioma(listal141[0], listal141[1]);



            _l.AddRange(new Leyenda[] { b9, b10, b11, b12, b13, b14, l6, l7, l8, l9, l10, l11, l12, l13, l14 });



            _cambioIdioma.Idioma = idioma;

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarUser RU = new RegistrarUser();
            RU.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string user = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                bll.BajaCuenta(user);
                MessageBox.Show("Usuario Borrado, actualice la tabla");
                DV.actualizarDV();
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Usuario Borrado", 5, DateTime.Now);
            }
            catch (Exception) { MessageBox.Show("Error"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string user = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nuevo = Interaction.InputBox("Agregue nuevo nombre de usuario: ");
                bll.ModUsuario(user,nuevo);
                MessageBox.Show("Actualizado el nombre, actualice la tabla.");
                DV.actualizarDV();
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Usuario Modificado", 5, DateTime.Now);
            }
            catch (Exception) { MessageBox.Show("Error"); }
        }
    }
}
