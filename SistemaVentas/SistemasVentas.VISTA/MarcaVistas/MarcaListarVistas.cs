using SistemasVentas.BSS;
using SistemasVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.MarcaVistas
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
            dataGridView1.DataSource = bss.ListarMarcasBss();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductoInsertarVistas.IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ProductoEditarVistas.IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarcaInsertarVistas fr = new MarcaInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarMarcasBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            MarcaEditarVISTAS fr = new MarcaEditarVISTAS(IdMarcaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarMarcasBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro que desea eliminar a esta persona?", "ELIMINAR", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarMarcaBss(IdMarcaSeleccionada);
                dataGridView1.DataSource = bss.ListarMarcasBss();
            }
        }
    }
}
