using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.RolVistas;
using SistemasVentas.VISTA.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolIngresarVISTAS : Form
    {
        public UsuarioRolIngresarVISTAS()
        {
            InitializeComponent();
        }
        public static int IdUsuarioSeleccionado = 0;
        public static int IdRolSeleccionado = 0;
        UsuarioRolBss bss = new UsuarioRolBss();
        UsuarioBss bssuser = new UsuarioBss();
        RolBss bssuser2 = new RolBss();

        private void button3_Click(object sender, EventArgs e)
        {
            UsuarioRol u = new UsuarioRol();
            u.IdUsuario = IdUsuarioSeleccionado;
            u.IdRol = IdRolSeleccionado;
            u.FechaAsig = dateTimePicker2.Value;

            bss.InsertarUsuarioRolBss(u);
            MessageBox.Show("Se guardo correctamente El Usuario Rol");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioListarVista fr = new UsuarioListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Usuario u = bssuser.ObtenerUsuarioIdBss(IdUsuarioSeleccionado);
                textBox1.Text = u.NombreUser;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RolListarVista fr = new RolListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                ROL r = bssuser2.ObtenerRolIdBss(IdRolSeleccionado);
                textBox2.Text = r.Nombre;
            }
        }
    }
}
