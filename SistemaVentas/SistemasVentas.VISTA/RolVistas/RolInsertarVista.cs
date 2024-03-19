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

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolInsertarVista : Form
    {
        public RolInsertarVista()
        {
            InitializeComponent();
        }
        RolBss bss= new RolBss();
        public static int IdRolSeleccionada = 0;
        private void txtNombreRol_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void RolInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            ROL p = new ROL();
            p.Nombre = txtNombreRol.Text;
            bss.InsertarRolBss(p);
            MessageBox.Show("Se guardo la nueva persona exitosamente");
        }

        private void txtNombreRol_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
