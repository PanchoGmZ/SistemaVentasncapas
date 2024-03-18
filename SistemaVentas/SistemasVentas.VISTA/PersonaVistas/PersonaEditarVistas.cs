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

namespace SistemasVentas.VISTA.PersonaVistas
{
    public partial class PersonaEditarVistas : Form
    {
        int idx = 0;
        Persona persona = new Persona();
        PersonaBss bss = new PersonaBss();
        public PersonaEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVistas_Load(object sender, EventArgs e)
        {
            persona = bss.ObtenerIdbss(idx);
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            txtTelefono.Text = persona.Telefono;
            txtCI.Text = persona.Ci;
            txtCorreo.Text = persona.Correo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Ci = txtCI.Text;
            persona.Correo = txtCorreo.Text;
            bss.EditarPersonaBss(persona);
            MessageBox.Show("Datos actualizados");
        }
    }
}
