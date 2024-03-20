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
using SistemasVentas.Modelos;
namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaInsertarVistas : Form
    {
        public MarcaInsertarVistas()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Marca p = new Marca();
            p.Nombre = textBox1.Text;
            bss.InsertarMarcaBss(p);
            MessageBox.Show("Se guardó la nueva persona exitosamente");
        }
    }
}
