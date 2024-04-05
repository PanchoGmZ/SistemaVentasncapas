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

namespace SistemaVentas.VISTA.ClienteVistas
{
    public partial class ClienteEditarVistas : Form
    {
        int idx = 0;
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssp = new PersonaBss();
        public ClienteEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.IdPersona = IdPersonaSeleccionada;
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoClie = textBox3.Text;
            cliente.Estado = txtEstado.Text;

            bss.EditarClienteBss(cliente);

            MessageBox.Show("Datos Actualizados");
        }

        private void ClienteEditarVistas_Load(object sender, EventArgs e)
        {
            cliente = bss.ObtenerClienteIdBss(idx);
            textBox1.Text = cliente.IdPersona.ToString();
            textBox2.Text = cliente.TipoCliente;
            textBox3.Text = cliente.CodigoClie;
            txtEstado.Text = cliente.Estado;
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssp.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }
    }
}
