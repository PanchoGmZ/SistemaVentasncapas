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

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaEditarVISTAS : Form
    {
        int idx = 0;
        Marca m = new Marca();
        MarcaBss bss = new MarcaBss();
        public MarcaEditarVISTAS(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void MarcaEditarVISTAS_Load(object sender, EventArgs e)
        {
            m = bss.ObtenerMarcaIdBss(idx);
            textBox1.Text = m.Nombre;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            m.Nombre = textBox1.Text;

            bss.EditarMarcaBss(m);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
