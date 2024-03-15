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
using SistemasVentas.Modelos;

namespace SistemasVentas.VISTA.TipoProdVistas
{
    public partial class TipoProdInsertarVista : Form
    {
        public TipoProdInsertarVista()
        {
            InitializeComponent();
        }
        TipoProductoBss bss=new TipoProductoBss();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TipoProducto p = new TipoProducto();
            p.Nombre = txtNombre.Text;
            bss.InsertarTipoProductoBss(p);
            MessageBox.Show("Se guardo exitosamente");
        }
    }
}
