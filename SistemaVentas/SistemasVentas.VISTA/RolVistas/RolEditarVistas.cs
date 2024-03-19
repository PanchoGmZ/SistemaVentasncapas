using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasVentas.DAL;
using SistemasVentas.BSS;
using SistemasVentas.Modelos;

namespace SistemasVentas.VISTA.RolVistas
{
    public partial class RolEditarVistas : Form
    {
        int idx = 0;
        ROL rol = new ROL();
        RolBss bss = new RolBss();
        public RolEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void RolEditarVistas_Load(object sender, EventArgs e)
        {
            rol = bss.ObtenerROlbss(idx);
            txtNombre.Text = rol.Nombre;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rol.Nombre = txtNombre.Text;
            bss.EditarRolBss(rol);
            MessageBox.Show("Datos actualizados");
        }
    }
}
