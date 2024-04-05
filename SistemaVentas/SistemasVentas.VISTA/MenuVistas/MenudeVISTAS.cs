using SistemasVentas.Vista.PersonaVistas;
using SistemasVentas.VISTA.ClienteVistas;
using SistemasVentas.VISTA.DetalleIng_Vistas;
using SistemasVentas.VISTA.DetalleVentaVistas;
using SistemasVentas.VISTA.IngresoVistas;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.ProductoVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.MenuVistas
{
    public partial class MenudeVISTAS : Form
    {
        public MenudeVISTAS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClienteListarVistas abrir = new ClienteListarVistas();
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DetalleIngListarVistas abrir = new DetalleIngListarVistas();
            abrir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DetalleVentaListarVistas abrir = new DetalleVentaListarVistas();
            abrir.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IngresoListarVistas abrir = new IngresoListarVistas();
            abrir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MarcaListarVistas abrir = new MarcaListarVistas();
            abrir.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PersonaListarVista abrir = new PersonaListarVista();
            abrir.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProductoListarVistas abrir = new ProductoListarVistas();
            abrir.Show();
        }
    }
}
