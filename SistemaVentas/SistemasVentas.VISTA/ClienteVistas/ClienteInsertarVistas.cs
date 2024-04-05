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

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVistas : Form
    {
        public ClienteInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        ClienteBss bss=new ClienteBss();
        PersonaBss bssp = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente p = new Cliente();
            p.IdPersona=IdPersonaSeleccionada;
            p.TipoCliente = textBox2.Text;
            p.CodigoCliente = textBox3.Text;
            bss.InsertarClienteBss(p);
            MessageBox.Show("Se guardo exitosamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona p = bssp.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = p.Nombre + " " + p.Apellido;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
