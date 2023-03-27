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
    public partial class Productos : Form
    {
        BLLProductos bll;
        bllBitacora bllBitacora;
        public Productos()
        {
            InitializeComponent();
            bll = new BLLProductos();
            bllBitacora = new bllBitacora();
        }

        private void PropuestasReparador_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MostrarProductos();
        }

        public void Mostrar(object pObject)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pObject;
        }

        public void MostrarProductos()
        {
            Mostrar(bll.DevolverProductos());
        }

        private void Ver_Click(object sender, EventArgs e)
        {
            try
            {
                    if (bll.CrearProducto(Interaction.InputBox("Agregue Nombre: "), Interaction.InputBox("Agregue Marca: "), int.Parse(Interaction.InputBox("Agregue Cantidad: ")), int.Parse(Interaction.InputBox("Agregue PrecioUnitario: ")), Interaction.InputBox("Agregue Descripcion: "), int.Parse(Interaction.InputBox("Agregue Cantidad Minima: ")), int.Parse(Interaction.InputBox("Agregue Cantidad Optima: "))) > 0)
                    {
                        MessageBox.Show("Producto creado con éxito!");
                        bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Producto Insertado", 4, DateTime.Now);
                    }
                    MostrarProductos();
            }catch(Exception ex) { MessageBox.Show("Hubo un error"); }
            
        }

        private void Baja_Click(object sender, EventArgs e)
        {
            try
            {
                string P = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                bll.BajaProducto(P);
                bll.BajaHistorica(P);
                bll.BajaVendidos(P);
                MostrarProductos();
                MessageBox.Show("Producto Borrado totalmente");
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Producto Borrado Totalmente", 4, DateTime.Now);
            }
            catch (Exception) { MessageBox.Show("Hubo un error"); }
        }

        private void BajaTemporal_Click(object sender, EventArgs e)
        {
            try
            {
                bool b = bool.Parse(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                string P = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if (b == true)
                {
                    bll.BajaTemporal(P);
                    MessageBox.Show("Producto Borrado temporalmente");
                }
                else { bll.BajaTemporal2(P); MessageBox.Show("Producto Desborrado"); }
                MostrarProductos();
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Producto Borrado Temporalmente", 4, DateTime.Now);
            } catch (Exception) { MessageBox.Show("Hubo un error"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nom = Interaction.InputBox("Agregue nombre: ");
                string mar = Interaction.InputBox("Agregue marca: ");
                int can = int.Parse(Interaction.InputBox("Agregue cantidad: "));
                int pu = int.Parse(Interaction.InputBox("Agregue precio unitario: "));
                string desc = Interaction.InputBox("Agregue descripcion: ");
                int cm = int.Parse(Interaction.InputBox("Agregue cantidad minima: "));
                int co = int.Parse(Interaction.InputBox("Agregue cantidad optima: "));
                int es = int.Parse(Interaction.InputBox("Agregue 1 o 0: "));
                bll.ModificarProductos(id, nom, mar, can, pu, desc, cm, co, es);
                MostrarProductos();
                MessageBox.Show("Producto Modificado Correctamente");
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Producto Modificado", 4, DateTime.Now);
            }catch (Exception) { MessageBox.Show("Hubo un error"); }
        }

        public void AvisarMinimo()
        {
            if (BEIdioma.IdiomaSeleccionado == "Español") { MessageBox.Show("Se bajo de la cantidad minima del producto, se recomienda hacer la nota de pedido"); } else { MessageBox.Show("You are below the minimum quantity of the product, it is recommended to make the order note"); }; NotaDePedido NT = new NotaDePedido(); NT.Show();
        }

        private void Venta_Click(object sender, EventArgs e)
        {
            try
            {
                bool P = bool.Parse(dataGridView1.SelectedRows[0].Cells[8].Value.ToString());
                if (P == true)
                {
                    string cantidad = Interaction.InputBox("Agregue cantidad vendida: ");
                    Producto pro = dataGridView1.SelectedRows[0].DataBoundItem as Producto;
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    string nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string marca = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    int cant = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    if (cant >= int.Parse(cantidad))
                    {
                        bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Venta Realizada", 4, DateTime.Now);
                        cant = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()) - int.Parse(cantidad);
                        int preciounitario = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                        string descripcion = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        int cantmin = int.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                        int cantopt = int.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                        int estado = 1;
                        bll.ModificarProductos(id, nombre, marca, cant, preciounitario, descripcion, cantmin, cantopt, estado);
                        int pos = dataGridView1.CurrentRow.Index;
                        MostrarProductos();
                        cant = int.Parse(cantidad);
                        if (bll.BuscarProducto(nombre) > 0)
                        {
                            bll.UpdateCantidad(cant, nombre);
                            if (BEIdioma.IdiomaSeleccionado == "Español")
                            {
                                MessageBox.Show("Cantidad Actualizada");
                            }
                            else { MessageBox.Show("Updated Quantity"); }
                            cant = int.Parse(dataGridView1.Rows[pos].Cells[3].Value.ToString());
                            if (cantmin >= cant) { AvisarMinimo(); }
                        }
                        else
                        {
                            bll.AltaProdVendidos(id, nombre, marca, cant, preciounitario, descripcion, cantmin, cantopt);
                            if (BEIdioma.IdiomaSeleccionado == "Español")
                            {
                                MessageBox.Show("Producto vendido por primera vez!");
                            }
                            else { MessageBox.Show("Product sold for the first time!"); }
                            cant = int.Parse(dataGridView1.Rows[pos].Cells[3].Value.ToString());
                            if (cantmin >= cant) { if (BEIdioma.IdiomaSeleccionado == "Español") { MessageBox.Show("Se bajo de la cantidad minima del producto, se recomienda hacer la nota de pedido"); } else { MessageBox.Show("You are below the minimum quantity of the product, it is recommended to make the order note"); }; NotaDePedido NT = new NotaDePedido(); NT.Show(); }
                        }
                    }
                    else { if (BEIdioma.IdiomaSeleccionado == "Español") { MessageBox.Show("La cantidad vendida no puede ser mayor al stock restante"); } else { MessageBox.Show("The quantity sold cannot be greater than the remaining stock"); } }
                }
                else { MessageBox.Show("El producto esta de baja Temporalmente"); }
            } catch (Exception) { if (BEIdioma.IdiomaSeleccionado == "Español") { MessageBox.Show("Hubo un error"); } else { MessageBox.Show("There was a mistake"); } }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label1.Visible = true;
                label3.Visible = true;
                labelPor1.Visible = true;
                labelPor2.Visible = true;
                int cantidad = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                int optima = int.Parse(dataGridView1.SelectedRows[0].Cells[7].Value.ToString());
                int minima = int.Parse(dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
                int porcentaje3 = bll.Porcentaje3(cantidad, optima);
                int porcentaje4 = bll.Porcentaje4(cantidad, minima);
                labelPor1.Text = porcentaje3.ToString();
                labelPor2.Text = porcentaje4.ToString();
            }
            catch (Exception) { if (BEIdioma.IdiomaSeleccionado == "Español") { MessageBox.Show("ERROR"); } else { MessageBox.Show("MISTAKE"); } }
        }
    }
}
