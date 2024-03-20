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
    public partial class ClienteInsertarVistas : Form
    {
        public ClienteInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdClienteSeleccionado = 0;
        ClienteBss bss=new ClienteBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente p = new Cliente();
            p.IdCliente = Convert.ToInt32(textBox1);
            p.TipoCliente = textBox2.Text;
            p.CodigoCliente = textBox3.Text;
            bss.InsertarClienteBss(p);
            MessageBox.Show("Se guardo exitosamente");
        }
    }
}
