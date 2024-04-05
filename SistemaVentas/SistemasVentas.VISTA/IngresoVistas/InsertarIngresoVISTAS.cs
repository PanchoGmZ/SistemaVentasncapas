using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemasVentas.VISTA.ProveedorVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class InsertarIngresoVISTAS : Form
    {
        public InsertarIngresoVISTAS()
        {
            InitializeComponent();
        }
        public static int IdProveedorSeleccionado = 0;
        ProveedorBss bssuser = new ProveedorBss();
        IngresoBss bss = new IngresoBss();

        private void button1_Click(object sender, EventArgs e)
        {
            Ingreso i = new Ingreso();
            i.IdProvedor = IdProveedorSeleccionado;
            i.FechaIngreso = dateTimePicker1.Value;
            i.Total = Convert.ToDecimal(textBox2.Text);

            bss.InsertarIngresosBss(i);
            MessageBox.Show("Se guardo correctamente El ingreso");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveedorListaVista fr = new ProveedorListaVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor p = bssuser.ObtenerProveedorIdBss(IdProveedorSeleccionado);
                textBox1.Text = p.Nombre;
            }
        }
    }
}
