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

namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolListarVistas : Form
    {
        public UsuarioRolListarVistas()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void UsuarioRolListarVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuarioRolBss();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            UsuarioRolInsertarVistas fr = new UsuarioRolInsertarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuarioRolBss();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            UsuarioRolEditarVistas fr = new UsuarioRolEditarVistas(IdSeleccionado);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarUsuarioRolBss();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int IdSeleccionado = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("¿Esta seguro de Eliminar este UsuarioRol?", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarUsuarioRolBss(IdSeleccionado);
                dataGridView1.DataSource = bss.ListarUsuarioRolBss();
            }
        }
    }
}
