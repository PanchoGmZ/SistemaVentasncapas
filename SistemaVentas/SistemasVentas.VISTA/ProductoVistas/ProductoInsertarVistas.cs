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

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class ProductoInsertarVistas : Form
    {
        public ProductoInsertarVistas()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();
            p.IdTipoProducto = Convert.ToInt32(textBox1.Text);
            p.IdMarca = Convert.ToInt32(textBox2.Text);
            p.Nombre = textBox3.Text;
            p.CodigoBarras = textBox4.Text;
            p.Unidad=textBox5.Text;
            p.Descripcion = textBox6.Text;
            bss.InsertarProductoBss(p);
            MessageBox.Show("Se guardo exitosamente");

        }

        private void ProductoInsertarVistas_Load(object sender, EventArgs e)
        {
         
        }
    }
}
