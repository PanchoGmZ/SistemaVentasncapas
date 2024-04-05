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

namespace SistemaVentas.VISTA.DetalleIngVistas
{
    public partial class DetalleIngListarVistas : Form
    {
        public DetalleIngListarVistas()
        {
            InitializeComponent();
        }
        DetalleIngBss bss = new DetalleIngBss();
        private void DetalleIngListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleIngBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetalleIngInsertarVistas fr = new DetalleIngInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetalleIngBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DetalleIngEditarVistas fr = new DetalleIngEditarVistas(IdSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarDetalleIngBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este DetalleIng?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarDetalleIngBss(IdSeleccionado);
                dataGridView1.DataSource = bss.ListarDetalleIngBss();
            }
        }
    }
}
