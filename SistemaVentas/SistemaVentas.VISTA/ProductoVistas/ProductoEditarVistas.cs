using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemaVentas.VISTA.MarcaVistas;
using SistemaVentas.VISTA.TipoProdVistas;
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

namespace SistemaVentas.VISTA.ProductoVistas
{
    public partial class ProductoEditarVistas : Form
    {
        int idx = 0;
        Producto producto = new Producto();
        ProductoBss bss = new ProductoBss();
        public ProductoEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdTipoProdSeleccionado = 0;
        TipoProdBss bsstp = new TipoProdBss();
        public static int IdMarcaSeleccionado = 0;
        MarcaBss bssm = new MarcaBss();
        private void ProductoEditarVistas_Load(object sender, EventArgs e)
        {
            producto = bss.ObtenerProductoIdBss(idx);
            txtIdTipoProd.Text = producto.IdTipoProducto.ToString();
            txtIdMarca.Text = producto.IdMarca.ToString();
            txtNombre.Text = producto.Nombre;
            txtCodigoBarra.Text = producto.CodigoBarra;
            txtUnidad.Text = producto.Unidad.ToString();
            txtDescripcion.Text = producto.Descripcion;
            txtEstado.Text = producto.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto.IdTipoProducto = IdTipoProdSeleccionado;
            producto.IdMarca = IdMarcaSeleccionado;
            producto.Nombre = txtNombre.Text;
            producto.CodigoBarra = txtCodigoBarra.Text;
            producto.Unidad = Convert.ToInt32(txtUnidad.Text);
            producto.Descripcion = txtDescripcion.Text;
            producto.Estado = txtEstado.Text;

            bss.EditarProductoBss(producto);

            MessageBox.Show("Datos Actualizados correctamente.");
        }

        private void btnSelecTiProd_Click(object sender, EventArgs e)
        {
            TipoProdListarVistas fr = new TipoProdListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProd tipoprod = bsstp.ObtenerTipoProdIdBss(IdTipoProdSeleccionado);
                txtIdTipoProd.Text = tipoprod.Nombre;
            }
        }

        private void btnSelecMarca_Click(object sender, EventArgs e)
        {
            MarcaListarVistas fr = new MarcaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bssm.ObtenerMarcaIdBss(IdMarcaSeleccionado);
                txtIdMarca.Text = marca.Nombre;
            }
        }
    }
}
