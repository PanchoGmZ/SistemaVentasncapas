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

namespace SistemaVentas.VISTA.ProveeVistas
{
    public partial class ProveeListarVistas : Form
    {
        public ProveeListarVistas()
        {
            InitializeComponent();
        }
        ProveeBss bss = new ProveeBss();
        private void ProveeListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveeBss();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProveeInsertarVistas fr = new ProveeInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveeBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProveeEditarVistas fr = new ProveeEditarVistas(IdSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveeBss();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Provee?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveeBss(IdSeleccionado);
                dataGridView1.DataSource = bss.ListarProveeBss();
            }
        }
    }
}
