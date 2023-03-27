using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using ENTIDADES;
using System.IO;

namespace Login_v1._1
{
    public partial class ProductosVendidos : Form
    {
        BLLVendidos bll;
        BLLProductos bllp;
        bllBitacora bllBitacora;
        Serializacion s;
        public ProductosVendidos()
        {
            InitializeComponent();
            bll = new BLLVendidos();
            bllp = new BLLProductos();
            s = new Serializacion();
            bllBitacora = new bllBitacora();
        }

        private void ProductosVendidos_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Mostrar(dataGridView1, bll.DevolverProductosVendidos());
        }

        public void Mostrar(DataGridView dgv,object obj)
        {
            dgv.DataSource = null;
            dgv.DataSource = obj;
        }

        private void NotaDePedido_Click(object sender, EventArgs e)
        {
            NotaDePedido NP = new NotaDePedido();
            NP.Show();
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                int productostotal = 0;
                int dineroganado = 0;
                foreach (DataRow row in bll.DevolverProductosVendidos().Rows)
                {
                    dineroganado += int.Parse(row.ItemArray[3].ToString()) * int.Parse(row.ItemArray[4].ToString());
                    productostotal += int.Parse(row.ItemArray[3].ToString());
                }
                MessageBox.Show("La cantidad de productos vendidos es de " + productostotal.ToString() + " y la cantidad de dinero ganado por las ventas es de " + dineroganado.ToString() + "$");


                int productosquedan = 0;
                foreach (DataRow row in bllp.DevolverProductos().Rows)
                {
                    productosquedan += int.Parse(row.ItemArray[7].ToString());
                }
                int a = (productostotal * 100) / productosquedan;
                MessageBox.Show("La cantidad de productos vendida es de " + a.ToString() + "%");
                bll.BorrarPorImprimir();
                Mostrar(dataGridView1, bll.DevolverProductosVendidos());
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Producto Impreso", 1, DateTime.Now);
            }
            catch (Exception) { MessageBox.Show("Hubo un error"); }
        }

        private void Serializar_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("C:\\Serializacion"))
                {
                    ProductoVendido pro = dataGridView1.SelectedRows[0].DataBoundItem as ProductoVendido;
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    string nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string marca = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    int cant = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    int preciounitario = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    pro = new ProductoVendido(id, nombre, marca, cant, preciounitario);
                    s.Serializar(pro, "C:\\Serializacion\\Producto.xml");
                    MessageBox.Show("El producto fue serializado a xml");
                    bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Producto Serializado", 5, DateTime.Now);
                }
                else
                {
                    DirectoryInfo dir = new DirectoryInfo("C:\\Serializacion");
                    dir.Create();
                    ProductoVendido pro = dataGridView1.SelectedRows[0].DataBoundItem as ProductoVendido;
                    string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    string nombre = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    string marca = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    int cant = int.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    int preciounitario = int.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
                    pro = new ProductoVendido(id, nombre, marca, cant, preciounitario);
                    s.Serializar(pro, "C:\\Serializacion\\Producto.xml");
                    MessageBox.Show("El producto fue serializado a xml");
                    bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Producto Serializado", 5, DateTime.Now);
                }
            }
            catch (Exception) { MessageBox.Show("Error"); }
        }

        private void Deserializar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoVendido pro = new ProductoVendido();
                pro = (ProductoVendido)s.Deserializar<ProductoVendido>("C:\\Serializacion\\Producto.xml");
                List<ProductoVendido> lista = new List<ProductoVendido>();
                lista.Add(pro);
                dataGridView2.DataSource = lista;
                bllBitacora.NuevaBitacora(Singleton.Instancia._usuarioS.usuario, "Producto Deserializado", 5, DateTime.Now);
            }
            catch (Exception) { MessageBox.Show("Error"); }
        }
    }
}
