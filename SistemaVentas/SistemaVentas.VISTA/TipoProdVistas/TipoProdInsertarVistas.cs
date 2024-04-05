using SistemasVentas.BSS;
using SistemasVentas.Modelos;
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
    public partial class TipoProdInsertarVistas : Form
    {
        public TipoProdInsertarVistas()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void button1_Click(object sender, EventArgs e)
        {
            TipoProd tipoProd = new TipoProd();
            tipoProd.Nombre = txtNombre.Text;
            tipoProd.Estado = txtEstado.Text;

            bss.InsertarTipoProdBss(tipoProd);

            MessageBox.Show("Se agrego correctamente este TipoProd.");
        }
    }
}
