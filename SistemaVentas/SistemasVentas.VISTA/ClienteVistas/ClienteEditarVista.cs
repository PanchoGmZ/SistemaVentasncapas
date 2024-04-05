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
    public partial class ClienteEditarVista : Form
    {
        int idc = 0;
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();
        PersonaBss bssp = new PersonaBss();
        public static int IdPersonaSeleccionada = 0;
        public ClienteEditarVista(int id)
        {
            idc = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            cliente = bss.ObtenerClienteIdBss(idc);
            textBox1.Text = cliente.IdPersona.ToString();
            textBox2.Text = cliente.TipoCliente;
            textBox3.Text = cliente.CodigoCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.IdPersona = IdPersonaSeleccionada;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoCliente = textBox3.Text;

            bss.EditarClienteBss(cliente);
            MessageBox.Show("Datos actualizados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssp.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
