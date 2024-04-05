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
    public partial class InsertarDetalleVentaVISTAS : Form
    {
        public InsertarDetalleVentaVISTAS()
        {
            InitializeComponent();
        }
        public static int IdVentaSeleccionada = 0;
        public static int IdProductoSeleccionada = 0;
        DetalleVentaBss bss = new DetalleVentaBss();
        VentaBss bssuser = new VentaBss();
        ProductoBss bssuser2 = new ProductoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta d = new DetalleVenta();
            d.IdVenta = IdVentaSeleccionada;
            d.IdProducto = IdProductoSeleccionada;
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox5.Text);
            d.SubTotal = Convert.ToDecimal(textBox6.Text);

            bss.InsertarDetalleVentaBss(d);
            MessageBox.Show("Se guardo correctamente El detalle de la venta");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentaListarVistas fr = new VentaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta v = bssuser.ObtenerVentaIdBss(IdVentaSeleccionada);
                textBox1.Text = v.Estado;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto p = bssuser2.ObtenerProductoIdBss(IdProductoSeleccionada);
                textBox2.Text = p.Nombre;
            }
        }
    }
}
