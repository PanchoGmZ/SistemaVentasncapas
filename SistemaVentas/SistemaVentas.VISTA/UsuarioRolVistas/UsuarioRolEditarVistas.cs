using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemaVentas.VISTA.RolVistas;
using SistemaVentas.VISTA.UsuarioVistas;
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

namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolEditarVistas : Form
    {
        int idx = 0;
        UsuarioRol usuarioRol = new UsuarioRol();
        UsuarioRolBss bss = new UsuarioRolBss();
        public UsuarioRolEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdUsuarioSeleccionado = 0;
        UsuarioBss bssu = new UsuarioBss();
        public static int IdRolSeleccionado = 0;
        RolBss bssr = new RolBss();
        private void UsuarioRolEditarVistas_Load(object sender, EventArgs e)
        {
            usuarioRol = bss.ObtenerUsuarioRolIdBss(idx);
            txtIdUsuario.Text = usuarioRol.IdUsuario.ToString();
            txtIdRol.Text = usuarioRol.IdRol.ToString();
            dateTimePicker1.Value = usuarioRol.FechaAsigna;
            txtEstado.Text = usuarioRol.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarioRol.IdUsuario = IdUsuarioSeleccionado;
            usuarioRol.IdRol = IdRolSeleccionado;
            usuarioRol.FechaAsigna = dateTimePicker1.Value;
            usuarioRol.Estado = txtEstado.Text;

            bss.EditarUsuarioRolBss(usuarioRol);

            MessageBox.Show("Datos Actualizados correctamente.");
        }

        private void btnSelecTiProd_Click(object sender, EventArgs e)
        {
            

        }

        private void btnSelecMarca_Click(object sender, EventArgs e)
        {
            RolListarVistas fr = new RolListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Rol rol = bssr.ObtenerIdBss(IdRolSeleccionado);
                txtIdRol.Text = rol.Nombre;
            }
        }
    }
}
