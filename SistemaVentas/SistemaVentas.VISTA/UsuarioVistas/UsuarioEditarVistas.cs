using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemaVentas.VISTA.PersonasVistas;
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

namespace SistemaVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioEditarVistas : Form
    {
        int idx = 0;
        Usuario usuario = new Usuario();
        UsuarioBss bss = new UsuarioBss();
        public UsuarioEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssp = new PersonaBss();
        private void UsuarioEditarVistas_Load(object sender, EventArgs e)
        {
            usuario = bss.ObtenerUsuarioIdBss(idx);
            txtIdPersona.Text = usuario.IdPersona.ToString();
            txtNombreUser.Text = usuario.NombreUser;
            txtContraseña.Text = usuario.Contraseña;
            dateTimePicker1.Value = usuario.FechaReg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = txtNombreUser.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bss.EditarUsuarioBss(usuario);

            MessageBox.Show("Datos Actualizados");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssp.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                txtNombreUser.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = txtNombreUser.Text;
            usuario.Contraseña = txtContraseña.Text;
            usuario.FechaReg = dateTimePicker1.Value;

            bss.EditarUsuarioBss(usuario);

            MessageBox.Show("Datos Actualizados correctamente.");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssp.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                txtNombreUser.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
