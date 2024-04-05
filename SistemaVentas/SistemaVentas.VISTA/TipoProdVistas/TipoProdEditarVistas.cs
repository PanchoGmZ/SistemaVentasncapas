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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdEditarVistas : Form
    {
        int idx = 0;
        TipoProd tipoProd = new TipoProd();
        TipoProdBss bss = new TipoProdBss();
        public TipoProdEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tipoProd.Nombre = txtNombre.Text;
            tipoProd.Estado = txtEstado.Text;

            bss.EditarTipoProdBss(tipoProd);
            MessageBox.Show("Datos Actualizados correctamente.");
        }

        private void TipoProdEditarVistas_Load(object sender, EventArgs e)
        {
            tipoProd = bss.ObtenerTipoProdIdBss(idx);
            txtNombre.Text = tipoProd.Nombre;
            txtEstado.Text = tipoProd.Estado;
        }
    }
}
