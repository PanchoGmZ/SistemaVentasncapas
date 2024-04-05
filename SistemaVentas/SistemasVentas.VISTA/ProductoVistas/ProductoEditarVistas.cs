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
    public partial class ProductoEditarVistas : Form
    {
        int idx = 0;
        Producto p = new Producto();
        ProductoBss bss = new ProductoBss();
        public static int IdTipoProdSeleccionada = 0;
        TipoProductoBss bsstip = new TipoProductoBss();
        public static int IdMarcaSeleccionada = 0;
        MarcaBss bssmar = new MarcaBss();
        public ProductoEditarVistas(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ProductoEditarVistas_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerProductoIdBss(idx);
            textBox1.Text = p.IdTipoProducto.ToString();
            textBox2.Text = p.IdMarca.ToString();
            textBox3.Text = p.Nombre;
            textBox4.Text = p.CodigoBarras;
            textBox5.Text = p.Unidad.ToString();
            textBox6.Text = p.Descripcion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            p.IdTipoProducto = IdTipoProdSeleccionada;
            p.IdMarca = IdMarcaSeleccionada;
            p.Nombre = textBox3.Text;
            p.CodigoBarras = textBox4.Text;
            p.Unidad = Convert.ToInt32(textBox5.Text);
            p.Descripcion = textBox6.Text;

            bss.EditarProductoBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TipoProdListarVista fr = new TipoProdListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                TipoProducto tipoprod = bsstip.ObtenerTipoProdIdBss(IdTipoProdSeleccionada);
                textBox1.Text = tipoprod.Nombre;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarcaListarVistas fr = new MarcaListarVistas();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Marca marca = bssmar.ObtenerMarcaIdBss(IdMarcaSeleccionada);
                textBox2.Text = marca.Nombre;
            }
        }
    }
}
