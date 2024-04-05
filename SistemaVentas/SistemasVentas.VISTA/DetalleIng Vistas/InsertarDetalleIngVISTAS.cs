using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.DetalleIng_Vistas
{
    public partial class InsertarDetalleIngVISTAS : Form
    {
        public InsertarDetalleIngVISTAS()
        {
            InitializeComponent();
        }
        public static int IdIngresoSeleccionado = 0;
        public static int IdProductoSeleccionado = 0;
        DetalleIngBss bss = new DetalleIngBss();
        IngresoBss bssuser = new IngresoBss();
        ProductoBss bssuser2 = new ProductoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIng d = new DetalleIng();
            d.IdIngreso = IdIngresoSeleccionado;
            d.IdProducto = IdProductoSeleccionado;
            d.FechaVenc = dateTimePicker1.Value;
            d.Cantidad = Convert.ToInt32(textBox3.Text);
            d.PrecioCosto = Convert.ToDecimal(textBox4.Text);
            d.PrecioVenta = Convert.ToDecimal(textBox5.Text);
            d.SubTotal = Convert.ToDecimal(textBox6.Text);

            bss.InsertarDetalleIngBss(d);
            MessageBox.Show("Se guardo correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IngresoListarVistas fr = new IngresoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso i = bssuser.ObtenerIngresosIdBss(IdIngresoSeleccionado);
                textBox1.Text = i.Estado;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto ingreso = bssuser2.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = ingreso.IdProducto.ToString();
            }
        }
    }
}
