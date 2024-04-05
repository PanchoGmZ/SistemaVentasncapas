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

namespace SistemaVentas.VISTA.PersonasVistas
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        Persona persona = new Persona();
        PersonaBss bss = new PersonaBss();
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            persona = bss.ObtenerPersonaIdBss(idx);
            txtNombre.Text = persona.Nombre;
            txtApellido.Text = persona.Apellido;
            txtTelefono.Text = persona.Telefono;
            txtCi.Text = persona.Ci;
            txtCorreo.Text = persona.Correo;
            txtEstado.Text = persona.Estado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Nombre = txtNombre.Text;
            persona.Apellido = txtApellido.Text;
            persona.Telefono = txtTelefono.Text;
            persona.Ci = txtCi.Text;
            persona.Correo = txtCorreo.Text;
            persona.Estado = txtEstado.Text;

            bss.EditarPersonaBss(persona);

            MessageBox.Show("Datos actualizados correctamente.");
        }
    }
}
