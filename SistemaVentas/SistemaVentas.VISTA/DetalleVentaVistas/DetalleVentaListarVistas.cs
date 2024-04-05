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

namespace SistemaVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaListarVistas : Form
    {
        public DetalleVentaListarVistas()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void DetalleVentaListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleVentaBss();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DetalleVentaInsertarVistas fr = new DetalleVentaInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetalleVentaBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleVentaEditarVistas fr = new DetalleVentaEditarVistas(IdSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetalleVentaBss();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este DetalleVenta?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleVentaBss(IdSeleccionado);
                dataGridView1.DataSource = bss.ListarDetalleVentaBss();
            }
        }
    }
}
