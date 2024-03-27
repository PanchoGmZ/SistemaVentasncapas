using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.BSS;

namespace SistemaVentasVISTAS2.BienvenidosVISTAS
{
    public partial class UsuarioDVistas : Form
    {
        public UsuarioDVistas()
        {
            InitializeComponent();
        }
        UsuarioBss bss = new UsuarioBss();
        private void UsuarioDVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarUsuariosBss();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AgregarUsuarioDVista abrir = new AgregarUsuarioDVista();
            abrir.Show();
        }
    }
}
