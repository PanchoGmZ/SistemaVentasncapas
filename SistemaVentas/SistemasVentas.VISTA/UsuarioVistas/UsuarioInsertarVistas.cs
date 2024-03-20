using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.Vista.PersonaVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class UsuarioInsertarVistas : Form
    {
        public UsuarioInsertarVistas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {

            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK) { }
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void UsuarioInsertarVistas_Load(object sender, EventArgs e)
        {




        }
        UsuarioBss bssuser = new UsuarioBss();
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona=IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contraeña = textBox3.Text;
            usuario.Fecha = dateTimePicker1.Value;
            bssuser.InsertarUsuarioBss(usuario);
            MessageBox.Show("Usuario registrado");
        }
    }
}
