using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProductoVistas;
using SistemasVentas.VISTA.VentaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class EditarDetalleVentaVISTAS : Form
    {
        int idx = 0;
        DetalleVenta p = new DetalleVenta();
        DetalleVentaBss bss = new DetalleVentaBss();
        public static int IdVentaSeleccionada = 0;
        VentaBss bssven = new VentaBss();
        public static int IdProductoSeleccionada = 0;
        ProductoBss bsspro = new ProductoBss();
        public EditarDetalleVentaVISTAS(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EditarDetalleVentaVISTAS_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerDetalleVentaIdBss(idx);
            textBox1.Text = p.IdVenta.ToString();
            textBox2.Text = p.IdProducto.ToString();
            textBox3.Text = p.Cantidad.ToString();
            textBox5.Text = p.PrecioVenta.ToString();
            textBox6.Text = p.SubTotal.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdVenta = IdVentaSeleccionada;
            p.IdProducto = IdProductoSeleccionada;
            p.Cantidad = Convert.ToInt32(textBox3.Text);
            p.PrecioVenta = Convert.ToDecimal(textBox5.Text);
            p.SubTotal = Convert.ToDecimal(textBox6.Text);

            bss.EditarDetalleVentaBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentaListarVistas fr = new VentaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bssven.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = venta.IdVenta.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspro.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox2.Text = producto.Nombre;
            }
        }
    }
}
