using SistemasVentas.BSS;
using SistemasVentas.Modelos;

using SistemaVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngInsertarVistas : Form
    {
        public DetalleIngInsertarVistas()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        public static int IdProductoSeleccionado = 0;
        ProductoBss bssp = new ProductoBss();
        public static int IdIngresoSeleccionado = 0;
        IngresoBss bssig = new IngresoBss();
        private void button1_Click_1(object sender, EventArgs e)
        {
            DetalleIng detalleIng = new DetalleIng();
            detalleIng.IdIngreso = IdIngresoSeleccionado;
            detalleIng.IdProducto = IdProductoSeleccionado;
            detalleIng.FechaVenc = dateTimePicker1.Value;
            detalleIng.Cantidad = Convert.ToInt32(txtCantidad.Text);
            detalleIng.PrecioCosto = Convert.ToDecimal(txtPrecioCosto.Text);
            detalleIng.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
            detalleIng.SubTotal = Convert.ToDecimal(txtSubTotal.Text);
            detalleIng.Estado = txtEstado.Text;

            bss.InsertarDetalleIngBss(detalleIng);

            MessageBox.Show("Se agrego correctamente Detalle Ing");
        }

        private void btnIng_Click(object sender, EventArgs e)
        {

        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto ingreso = bssp.ObtenerProductoIdBss(IdProductoSeleccionado);
                txtProducto.Text = ingreso.IdProducto.ToString();
            }
        }
    }
}
