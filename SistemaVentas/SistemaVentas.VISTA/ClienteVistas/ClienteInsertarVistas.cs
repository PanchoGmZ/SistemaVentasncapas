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

namespace SistemaVentas.VISTA.ClienteVistas
{
    public partial class ClienteInsertarVistas : Form
    {
        public ClienteInsertarVistas()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bssp = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.IdPersona = IdPersonaSeleccionada;
            cliente.TipoCliente = txtTipoCliente.Text;
            cliente.CodigoClie = txtCodigoCliente.Text;
            cliente.Estado = txtEstado.Text;

            bss.InsertarClienteBss(cliente);

            MessageBox.Show("Se agrego correctamente el cliente.");
        }

        private void btnSelec_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bssp.ObtenerPersonaIdBss(IdPersonaSeleccionada);
                txtIdPersona.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        private void ClienteInsertarVistas_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
