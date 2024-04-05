using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.TipoProdVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoInsertarVistas : Form
    {
        public ProductoInsertarVistas()
        {
            InitializeComponent();
        }
        public static int IdTipoProdSeleccionada = 0;
        public static int IdMarcaSeleccionada = 0;
        ProductoBss bss = new ProductoBss();
        TipoProductoBss bssuser = new TipoProductoBss();
        MarcaBss bssuser2 = new MarcaBss();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.IdTipoProducto = Convert.ToInt32(textBox1.Text);
            p.IdMarca = Convert.ToInt32(textBox2.Text);
            p.Nombre = textBox3.Text;
            p.CodigoBarras = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;
            bss.InsertarProductoBss(p);
            MessageBox.Show("Se guardo exitosamente");

        }

        private void ProductoInsertarVistas_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipoProdListarVista fr = new TipoProdListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProducto t = bssuser.ObtenerTipoProdIdBss(IdTipoProdSeleccionada);
                textBox1.Text = t.Nombre;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarcaListarVistas fr = new MarcaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca m = bssuser2.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox2.Text = m.Nombre;
            }
        }
    }
}
