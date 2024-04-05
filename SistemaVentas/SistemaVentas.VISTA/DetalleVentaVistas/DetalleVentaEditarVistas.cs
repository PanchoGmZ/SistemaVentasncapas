using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemaVentas.VISTA.ProductoVistas;
using SistemaVentas.VISTA.VentaVistas;
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

namespace SistemaVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaEditarVistas : Form
    {
        int idx = 0;
        DetalleVenta detalleVenta = new DetalleVenta();
        DetalleVentaBss bss = new DetalleVentaBss();
        public DetalleVentaEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdVentaSeleccionado = 0;
        VentaBss bssv = new VentaBss();
        public static int IdProductoSeleccionado = 0;
        ProductoBss bsspd = new ProductoBss();

        private void DetalleVentaEditarVistas_Load(object sender, EventArgs e)
        {
            detalleVenta = bss.ObtenerDetalleVentaIdBss(idx);
            txtIdVenta.Text = detalleVenta.IdVenta.ToString();
            txtIdProducto.Text = detalleVenta.IdProducto.ToString();
            txtCantidad.Text = detalleVenta.Cantidad.ToString();
            txtPrecioVenta.Text = detalleVenta.PrecioVenta.ToString();
            txtSubTotal.Text = detalleVenta.SubTotal.ToString();
            txtEstado.Text = detalleVenta.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            detalleVenta.IdVenta = IdVentaSeleccionado;
            detalleVenta.IdProducto = IdProductoSeleccionado;
            detalleVenta.Cantidad = Convert.ToInt32(txtCantidad.Text);
            detalleVenta.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            detalleVenta.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
            detalleVenta.Estado = txtEstado.Text;

            bss.EditarDetalleVentaBss(detalleVenta);

            MessageBox.Show("Datos Actualizados correctamente.");
        }

        private void btnSelecVenta_Click(object sender, EventArgs e)
        {
            VentaListarVistas fr = new VentaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Venta venta = bssv.ObtenerVentaIdBss(IdVentaSeleccionado);
                txtIdVenta.Text = venta.IdVenta.ToString();
            }
        }

        private void btnSelecProducto_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspd.ObtenerProductoIdBss(IdProductoSeleccionado);
                txtIdProducto.Text = producto.Nombre;
            }
        }
    }
}
