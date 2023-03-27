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
    public partial class Ventas : Form
    {
        BLLVentas bll;
        bllBitacora bllBitacora;
        Random rn;
        int random;
        public Ventas()
        {
            InitializeComponent();
            bll = new BLLVentas();
            bllBitacora = new bllBitacora();
            rn = new Random();
            random = rn.Next(1, 10000);
        }

        public void Mostrar(object pObject)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pObject;
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bll.DevolverProductos();
            string nombre;
            int cantidad = 0;
            foreach(DataRow row in bll.DevolverCarrito().Rows)
            {
                nombre = row.ItemArray[1].ToString();
                cantidad = int.Parse(row.ItemArray[3].ToString());
                bll.UpdateCantidadInverso(cantidad, nombre);
                bll.UpdateCantidadVendidosInverso(cantidad, nombre);
            }
            bll.BajaCarrito();
        }

        public void MostrarProductos()
        {
            Mostrar(bll.DevolverProductos());
        }

        public void AvisarMinimo()
        {
            if (BEIdioma.IdiomaSeleccionado == "Español") { MessageBox.Show("Se bajo de la cantidad minima del producto, se recomienda hacer la nota de pedido"); } else { MessageBox.Show("You are below the minimum quantity of the product, it is recommended to make the order note"); }; NotaDePedido NT = new NotaDePedido(); NT.Show();
        }
        private void AgregarCar_Click(object sender, EventArgs e)
        {
            try
            {
                string cantidad = Interaction.InputBox("Agregue cantidad vendida: ");
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string marca = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                int cant = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                int pu = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                string comp = Singleton.Instancia._usuarioS.usuario;
                if (cant >= int.Parse(cantidad))
                {
                    bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Venta Realizada", 4, DateTime.Now);
                    cant = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()) - int.Parse(cantidad);
                    bll.ActualizarCantidad(id, cant);
                    int pos = dataGridView1.CurrentRow.Index;
                    MostrarProductos();
                    cant = int.Parse(cantidad);
                    if (bll.BuscarProducto(nombre) > 0)
                    {
                        bll.UpdateDeCantidad(nombre, cant);
                        bll.UpdateDeCantidadVendidos(cant, nombre);
                        dataGridView2.DataSource = bll.DevolverCarrito();
                        if (BEIdioma.IdiomaSeleccionado == "Español")
                        {
                            MessageBox.Show("Cantidad Actualizada");
                        }
                        else { MessageBox.Show("Updated Quantity"); }
                        cant = int.Parse(dataGridView1.Rows[pos].Cells[3].Value.ToString());
                        //if (bll.CantMin(nombre) >= cant) { AvisarMinimo(); }
                    }
                    else
                    {
                        bll.AltaCarrito(random.ToString(), nombre, marca, cant, pu, comp);
                        if (bll.BuscarProductosVendidos(nombre) > 0)
                        {
                            bll.UpdateDeCantidadVendidos(cant, nombre);
                        }
                        else
                        {
                            bll.AltaProductosVendidos(id, nombre, marca, int.Parse(cantidad), pu);
                        }
                        dataGridView2.DataSource = bll.DevolverCarrito();
                        if (BEIdioma.IdiomaSeleccionado == "Español")
                        {
                            MessageBox.Show("Producto vendido por primera vez!");
                        }
                        else { MessageBox.Show("Product sold for the first time!"); }
                        cant = int.Parse(dataGridView1.Rows[pos].Cells[3].Value.ToString());
                        //if (bll.CantMin(nombre) >= cant) { if (BEIdioma.IdiomaSeleccionado == "Español") { MessageBox.Show("Se bajo de la cantidad minima del producto, se recomienda hacer la nota de pedido"); } else { MessageBox.Show("You are below the minimum quantity of the product, it is recommended to make the order note"); }; NotaDePedido NT = new NotaDePedido(); NT.Show(); }
                    }
                }
                else { if (BEIdioma.IdiomaSeleccionado == "Español") { MessageBox.Show("La cantidad vendida no puede ser mayor al stock restante"); } else { MessageBox.Show("The quantity sold cannot be greater than the remaining stock"); } }
            }
            catch (Exception) { MessageBox.Show("ERROR"); }
        }

        private void VenderProd_Click(object sender, EventArgs e)
        {
            try
            {
                int dinerogastado = 0;
                foreach (DataRow row in bll.DevolverCarrito().Rows)
                {
                    dinerogastado += int.Parse(row.ItemArray[3].ToString()) * int.Parse(row.ItemArray[4].ToString());
                    bll.AltaVendidos(row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), row.ItemArray[2].ToString(), int.Parse(row.ItemArray[3].ToString()), int.Parse(row.ItemArray[4].ToString()), row.ItemArray[5].ToString());
                }
                bll.AltaCompras(random.ToString(), DateTime.Now, dinerogastado, Singleton.Instancia._usuarioS.usuario);
                bll.BajaCarrito();
                dataGridView2.DataSource = bll.DevolverCarrito();
                random = rn.Next(1, 10000);
                MessageBox.Show("Carrito Comprado");
            }
            catch (Exception) { MessageBox.Show("ERROR"); }

        }

        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                string nombre;
                int cantidad = 0;
                foreach (DataRow row in bll.DevolverCarrito().Rows)
                {
                    nombre = row.ItemArray[1].ToString();
                    cantidad = int.Parse(row.ItemArray[3].ToString());
                    bll.UpdateCantidadInverso(cantidad, nombre);
                    bll.UpdateCantidadVendidosInverso(cantidad, nombre);
                }
                bll.BajaCarrito();
            }
            catch (Exception) { MessageBox.Show("ERROR"); }
        }
    }
}
