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
    public partial class EditarDetalleIngresoVISTAS : Form
    {
        int idx = 0;
        DetalleIng detalleIng = new DetalleIng();
        DetalleIngBss bss = new DetalleIngBss();
        public EditarDetalleIngresoVISTAS(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bsspd = new ProductoBss();
        public static int IdIngresoSeleccionado = 0;
        IngresoBss bssin = new IngresoBss();

        private void EditarDetalleIngresoVISTAS_Load(object sender, EventArgs e)
        {
            detalleIng = bss.ObtenerDetalleIngIdBss(idx);
            textBox1.Text = detalleIng.IdIngreso.ToString();
            textBox2.Text = detalleIng.IdProducto.ToString();
            dateTimePicker1.Value = detalleIng.FechaVenc;
            textBox3.Text = detalleIng.Cantidad.ToString();
            textBox4.Text = detalleIng.PrecioCosto.ToString();
            textBox5.Text = detalleIng.PrecioVenta.ToString();
            textBox6.Text = detalleIng.SubTotal.ToString();
  
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            detalleIng.IdIngreso = IdIngresoSeleccionado;
            detalleIng.IdProducto = IdProductoSeleccionado;
            detalleIng.FechaVenc = dateTimePicker1.Value;
            detalleIng.Cantidad = Convert.ToInt32(textBox3.Text);
            detalleIng.PrecioCosto = Convert.ToDecimal(textBox4.Text);
            detalleIng.PrecioVenta = Convert.ToDecimal(textBox5.Text);
            detalleIng.SubTotal = Convert.ToDecimal(textBox6.Text);
          

            bss.EditarDetalleIngBss(detalleIng);

            MessageBox.Show("Datos Actualizados correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IngresoListarVistas fr = new IngresoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Ingreso ingreso = bssin.ObtenerIngresosIdBss(IdIngresoSeleccionado);
                textBox1.Text = ingreso.IdIngreso.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspd.ObtenerProductoIdBss(IdProductoSeleccionado);
                textBox2.Text = producto.Nombre;
            }
        }
    }
}
