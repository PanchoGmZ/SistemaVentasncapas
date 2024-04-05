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

namespace SistemaVentas.VISTA.VentaVistas
{
    public partial class VentaListarVistas : Form
    {
        public VentaListarVistas()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        private void VentaListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarVentaBss();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VentaInsertarVistas fr = new VentaInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaEditarVistas fr = new VentaEditarVistas(IdSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Venta?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarVentaBss(IdSeleccionado);
                dataGridView1.DataSource = bss.ListarVentaBss();
            }
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            DetalleVentaVistas.DetalleVentaInsertarVistas.IdVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaVistas.DetalleVentaEditarVistas.IdVentaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
