using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemaVentas.VISTA.ProductoVistas;
using SistemaVentas.VISTA.ProveedorVistas;
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

namespace SistemaVentas.VISTA.ProveeVistas
{
    public partial class ProveeInsertarVistas : Form
    {
        public ProveeInsertarVistas()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        public static int IdProductoSeleccionado = 0;
        ProductoBss bsspd = new ProductoBss();
        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bsspv = new ProveedorBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee provee = new Provee();
            provee.IdProducto = IdProductoSeleccionado;
            provee.IdProveedor = IdProveedorSeleccionado;
            provee.Fecha = dateTimePicker1.Value;
            provee.Precio = Convert.ToDecimal(txtPrecio.Text);

            bss.InsertarProveeBss(provee);

            MessageBox.Show("Se agrego correctamente este provee.");
        }

        private void btnSelecProd_Click(object sender, EventArgs e)
        {
            ProductoListarVistas fr = new ProductoListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Producto producto = bsspd.ObtenerProductoIdBss(IdProductoSeleccionado);
                txtIdProducto.Text = producto.Nombre;
            }
        }

        private void btnSelecProvee_Click(object sender, EventArgs e)
        {
            ProveedorListarVistas fr = new ProveedorListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bsspv.ObtenerProveedorIdBss(IdProveedorSeleccionado);
                txtProveedor.Text = proveedor.Nombre;
            }
        }
    }
}
