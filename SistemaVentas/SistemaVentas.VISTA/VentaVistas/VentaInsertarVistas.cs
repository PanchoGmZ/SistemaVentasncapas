using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemaVentas.VISTA.ClienteVistas;
using SistemaVentas.VISTA.UsuarioVistas;
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

namespace SistemaVentas.VISTA.VentaVistas
{
    public partial class VentaInsertarVistas : Form
    {
        public VentaInsertarVistas()
        {
            InitializeComponent();
        }
        VentaBss bss = new VentaBss();
        public static int IdClienteSeleccionado = 0;
        ClienteBss bssc = new ClienteBss();
        public static int IdVendedorSeleccionado = 0;
        UsuarioBss bssus = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();
            venta.IdCliente = IdClienteSeleccionado;
            venta.IdVendedor = IdVendedorSeleccionado;
            venta.Fecha = dateTimePicker1.Value;
            venta.Total = Convert.ToDecimal(txtTotal.Text);
            venta.Estado = txtEstado.Text;

            bss.InsertarVentaBss(venta);
            MessageBox.Show("Se agrego correctamente la venta.");
        }

        private void btnSelecliente_Click(object sender, EventArgs e)
        {
            ClienteListarVistas fr = new ClienteListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Cliente cliente = bssc.ObtenerClienteIdBss(IdClienteSeleccionado);
                txtIdCliente.Text = cliente.IdCliente.ToString();
            }
        }

        private void btnSelecVendedor_Click(object sender, EventArgs e)
        {

        }
    }
}
