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

namespace SistemaVentas.VISTA.MarcaVistas
{
    public partial class MarcaListarVistas : Form
    {
        public MarcaListarVistas()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void MarcaListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarMarcaBss();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MarcaInsertarVistas fr = new MarcaInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            MarcaEditarVistas fr = new MarcaEditarVistas(IdSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar esta Marca?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarMarcaBss(IdSeleccionado);
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            ProductoVistas.ProductoInsertarVistas.IdMarcaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoVistas.ProductoEditarVistas.IdMarcaSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
