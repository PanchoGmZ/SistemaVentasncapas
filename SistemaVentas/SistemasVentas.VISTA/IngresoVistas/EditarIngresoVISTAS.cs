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
    public partial class EditarIngresoVISTAS : Form
    {
        int idx = 0;
        Ingreso p = new Ingreso();
        IngresoBss bss = new IngresoBss();
        public static int IdProveedorSeleccionada = 0;
        ProveedorBss bssprov = new ProveedorBss();
        public EditarIngresoVISTAS(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EditarIngresoVISTAS_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerIngresosIdBss(idx);
            textBox1.Text = p.IdProvedor.ToString();
            dateTimePicker1.Value = p.FechaIngreso;
            textBox2.Text = p.Total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.IdProvedor = IdProveedorSeleccionada;
            p.FechaIngreso = dateTimePicker1.Value;
            p.Total = Convert.ToDecimal(textBox2.Text);

            bss.EditarIngresosBss(p);
            MessageBox.Show("Datos Actualizados");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProveedorListaVista fr = new ProveedorListaVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Proveedor proveedor = bssprov.ObtenerProveedorIdBss(IdProveedorSeleccionada);
                textBox1.Text = proveedor.Nombre;
            }
        }
    }
}
