using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemaVentas.VISTA.ClienteVistas;
using SistemaVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.PantallaVistas
{
    public partial class VentasVistas : Form
    {
        public VentasVistas()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("idcliente", "ID Cliente");
            dataGridView1.Columns.Add("idproducto", "ID Producto");
            dataGridView1.Columns.Add("nombre", "Nombre Producto");
            dataGridView1.Columns.Add("cantidad", "Cantidad");
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bsspd = new ProductoBss();
        public static int IdClienteSeleccionado = 0;
        ClienteBss bssc = new ClienteBss();
        private void button2_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspd.ObtenerProductoIdBss(IdProductoSeleccionado);
                txtProducto.Text = producto.Nombre;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteListarVistas fr = new ClienteListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bssc.ObtenerClienteIdBss(IdClienteSeleccionado);
                textBox1.Text = cliente.IdCliente.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = bssc.ObtenerClienteIdBss(IdClienteSeleccionado);
            Producto producto = bsspd.ObtenerProductoIdBss(IdProductoSeleccionado);
            int cantidad;
            if (!int.TryParse(textBox4.Text, out cantidad))
            {
                MessageBox.Show("Ingrese una cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AgregarProductoSeleccionadoAlDataGridView(producto, cliente, cantidad);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void AgregarProductoSeleccionadoAlDataGridView(Producto producto, Cliente cliente, int cantidad)
        {
            if (dataGridView1 != null)
            {
                dataGridView1.Rows.Add(cliente.IdCliente, producto.IdProducto, producto.Nombre, cantidad);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToDouble(row.Cells["Cantidad"].Value);
            }
            textBox2.Text = total.ToString();
        }
    }
}




