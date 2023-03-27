using BLL;
using ENTIDADES;
using Microsoft.VisualBasic;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_v1._1
{
    public partial class FormIdioma : Form
    {
        public FormIdioma()
        {
            InitializeComponent();
            bllBitacora = new bllBitacora();
        }
        public BLLIdioma _bllI;
        public BLLTraduccion _bllT;
        public BLLForm _bllF;
        public BLLControl _bllC;
        public string IdiomaSeleccionado;
        bllBitacora bllBitacora;

        private void FormIdioma_Load(object sender, EventArgs e)
        {
            ActualizarTodo();
        }

        public void ActualizarTodo()
        {
            _bllT = new BLLTraduccion();
            _bllC = new BLLControl();
            try
            {
                _bllF = new BLLForm();
                _bllI = new BLLIdioma();
                _bllT = new BLLTraduccion();


                foreach (BEControl C in _bllF.RetornarControles(this.Name.ToString()))
                {
                    foreach (Control _c in this.Controls)
                    {
                        if (_c.Name == C.NombreControl)
                        {
                            _c.Text = _bllT.Traducir(IdiomaSeleccionado, this.Name.ToString(), C.NombreControl);
                        }
                    }
                }

                dataGridView1.MultiSelect = false; dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Rows.Clear();
                _bllF = new BLLForm();
                comboBox1.DataSource = _bllF.RetornarLista();
                comboBox1.DisplayMember = "NombreForm";
                comboBox1.ValueMember = "NombreForm";
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

                _bllI = new BLLIdioma();
                comboBox3.DataSource = _bllI.RetornarLista();
                comboBox3.DisplayMember = "NombreIdioma";
                comboBox3.ValueMember = "NombreIdioma";
                comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception) { }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (comboBox1.SelectedValue is BEForm)
            {
                comboBox2.DataSource = _bllF.RetornarControles((comboBox1.SelectedValue as BEForm).NombreForm);

                foreach (BETraduccion T in _bllT.RetornarLista().FindAll(x => x.Form.NombreForm == (comboBox1.SelectedValue as BEForm).NombreForm && x.Idioma.NombreIdioma == "Español"))
                {
                    dataGridView1.Rows.Add(T.Form.NombreForm, T.Control.NombreControl, T.Traduccion);
                }
            }
            else
            {

                comboBox2.DataSource = _bllF.RetornarControles(comboBox1.SelectedValue.ToString());

                foreach (BETraduccion T in _bllT.RetornarLista().FindAll(x => x.Form.NombreForm == comboBox1.SelectedValue.ToString() && x.Idioma.NombreIdioma == "Español"))
                {
                    dataGridView1.Rows.Add(T.Form.NombreForm, T.Control.NombreControl, T.Traduccion);
                }
            }

            comboBox2.DisplayMember = "NombreControl";
            comboBox2.ValueMember = "NombreControl";
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void LlenarTextbox()
        {
            textBox1.Text = "";

            if (comboBox1.Items.Count != 0 && comboBox2.Items.Count != 0 && comboBox3.Items.Count != 0)
            {
                if (comboBox1.SelectedValue is BEForm)
                {

                    textBox1.Text = _bllT.Traducir((comboBox3.SelectedValue as BEIdioma).NombreIdioma, (comboBox1.SelectedValue as BEForm).NombreForm, (comboBox2.SelectedValue as BEControl).NombreControl);
                }
                else
                {

                    textBox1.Text = _bllT.Traducir(comboBox3.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(), comboBox2.SelectedValue.ToString());
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTextbox();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarTextbox();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0 && comboBox2.Items.Count != 0 && comboBox3.Items.Count != 0)
            {
                if (textBox2.Text != "")
                {
                    if (comboBox1.SelectedValue is BEForm)
                    {
                        _bllT.AgregarTraduccion(new object[] { (comboBox3.SelectedValue as BEIdioma).NombreIdioma, (comboBox1.SelectedValue as BEForm).NombreForm, (comboBox2.SelectedValue as BEControl).NombreControl, textBox2.Text });
                    }
                    else
                    {

                        _bllT.AgregarTraduccion(new object[] { comboBox3.SelectedValue.ToString(), comboBox1.SelectedValue.ToString(), comboBox2.SelectedValue.ToString(), textBox2.Text });
                    }
                    textBox2.Text = "";
                    MessageBox.Show("Se agrego Traduccion.\nReinicie la aplicacion para Actualizar los textos modificados");
                    comboBox1_SelectedIndexChanged(null, null);
                    bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Idioma Actualizado", 5, DateTime.Now);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Formulario, Control e Idioma para agregar traduccion. ");
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            _bllI.AgregarIdioma(new object[] { Interaction.InputBox("Ingrese Nombre del Idioma: ") });
            ActualizarTodo();
            bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Idioma Agregado", 5, DateTime.Now);
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            try
            {
                string a = comboBox3.Text;
                _bllI.BajaIdioma(a);
                _bllI.BajaIdioma2(a);
                ActualizarTodo();
                MessageBox.Show("Se borro el idioma " + a + " exitosamente");
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Idioma Borrado", 5, DateTime.Now);
            }
            catch (Exception) { MessageBox.Show("Error"); }
        }
    }
}
