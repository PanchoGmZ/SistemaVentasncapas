using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.VISTA.ProductoVistas
{
    public partial class ProductoListarVistas : Form
    {
        public ProductoListarVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ProductoListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoBss();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProductoInsertarVistas fr = new ProductoInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProductoBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoEditarVistas fr = new ProductoEditarVistas(IdSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProductoBss();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Producto?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProductoBss(IdSeleccionado);
                dataGridView1.DataSource = bss.ListarProductoBss();
            }
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            DetalleVentaVistas.DetalleVentaInsertarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleIngVistas.DetalleIngInsertarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeVistas.ProveeInsertarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaVistas.DetalleVentaEditarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleIngVistas.DetalleIngEditarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeVistas.ProveeEditarVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PantallaVistas.VentasVistas.IdProductoSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
