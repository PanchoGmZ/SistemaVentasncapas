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

namespace SistemaVentas.VISTA.ClienteVistas
{
    public partial class ClienteListarVistas : Form
    {
        public ClienteListarVistas()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void ClienteListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteBss();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ClienteInsertarVistas fr = new ClienteInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            ClienteEditarVistas fr = new ClienteEditarVistas(IdSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este Cliente?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarClienteBss(IdSeleccionada);
                dataGridView1.DataSource = bss.ListarClienteBss();
            }
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            VentaVistas.VentaInsertarVistas.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            VentaVistas.VentaEditarVistas.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PantallaVistas.VentasVistas.IdClienteSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
    }
}
