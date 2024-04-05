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

namespace SistemaVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdListarVistas : Form
    {
        public TipoProdListarVistas()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void TipoProdListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarTipoProdBss();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            TipoProdInsertarVistas fr = new TipoProdInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarTipoProdBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            TipoProdEditarVistas fr = new TipoProdEditarVistas(IdSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarTipoProdBss();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este TipoProd?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarTipoProdBss(IdSeleccionado);
                dataGridView1.DataSource = bss.ListarTipoProdBss();
            }
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            ProductoVistas.ProductoInsertarVistas.IdTipoProdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoVistas.ProductoEditarVistas.IdTipoProdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
