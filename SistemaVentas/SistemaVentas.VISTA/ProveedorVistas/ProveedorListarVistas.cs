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

namespace SistemaVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorListarVistas : Form
    {
        public ProveedorListarVistas()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void ProveedorListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProveedorInsertarVistas fr = new ProveedorInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveedorEditarVistas fr = new ProveedorEditarVistas(IdPersonaSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Proveedor?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveedorBss(IdPersonaSeleccionado);
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {

        }
    }
}
