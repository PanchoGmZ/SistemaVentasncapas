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
    public partial class ProveeEditarVistas : Form
    {
        int idx = 0;
        Provee provee = new Provee();
        ProveeBss bss = new ProveeBss();
        public ProveeEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdProductoSeleccionado = 0;
        ProductoBss bsspd = new ProductoBss();
        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bsspv = new ProveedorBss();
        private void ProveeEditarVistas_Load(object sender, EventArgs e)
        {
            provee = bss.ObtenerProveeIdBss(idx);
            txtIdProducto.Text = provee.IdProducto.ToString();
            txtProveedor.Text = provee.IdProveedor.ToString();
            dateTimePicker1.Value = provee.Fecha;
            txtPrecio.Text = provee.Precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            provee.IdProducto = IdProductoSeleccionado;
            provee.IdProveedor = IdProveedorSeleccionado;
            provee.Fecha = dateTimePicker1.Value;
            provee.Precio = Convert.ToDecimal(txtPrecio.Text);

            bss.EditarProveeBss(provee);

            MessageBox.Show("Datos Actualizados correctamente.");
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
