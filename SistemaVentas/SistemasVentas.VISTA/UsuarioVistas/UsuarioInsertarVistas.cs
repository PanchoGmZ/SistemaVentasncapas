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
        public static int IdPersonaSeleccionda = 0;
        PersonaBss bss = new PersonaBss();
        private void btn_Seleccionar_Click(object sender, EventArgs e)
        {
        
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK) { }
            {
                Persona persona = bss.ObtenerIdbss(IdPersonaSeleccionda);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void UsuarioInsertarVistas_Load(object sender, EventArgs e)
        {
           
 


        }
    }
}
