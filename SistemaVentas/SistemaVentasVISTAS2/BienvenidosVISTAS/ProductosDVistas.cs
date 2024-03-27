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

namespace SistemaVentasVISTAS2.BienvenidosVISTAS
{
    public partial class ProductosDVistas : Form
    {
        public ProductosDVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void ProductosDVistas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoBss();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AgregarProductoDVistas abrir = new AgregarProductoDVistas();
            abrir.Show();
        }
    }
}
