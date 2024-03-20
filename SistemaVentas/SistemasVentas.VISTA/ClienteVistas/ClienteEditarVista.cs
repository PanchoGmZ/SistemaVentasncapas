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

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ClienteEditarVista : Form
    {
        int idc = 0;
        Cliente cliente = new Cliente();
        ClienteBss bss = new ClienteBss();
        public ClienteEditarVista(int id)
        {
            idc = id;
            InitializeComponent();
        }

        private void ClienteEditarVista_Load(object sender, EventArgs e)
        {
            cliente = bss.ObtenerIdClienteBss(idc);
            textBox2.Text = cliente.TipoCliente;
            textBox3.Text = cliente.CodigoCliente;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.TipoCliente = textBox2.Text;
            cliente.CodigoCliente = textBox3.Text;

            bss.EditarClienteBss(cliente);
            MessageBox.Show("Datos actualizados");
        }
    }
}
