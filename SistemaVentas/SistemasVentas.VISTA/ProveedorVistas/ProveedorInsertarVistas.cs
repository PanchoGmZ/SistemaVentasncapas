﻿using SistemasVentas.BSS;
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

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class ProveedorInsertarVistas : Form
    {
        public ProveedorInsertarVistas()
        {
            InitializeComponent();
        }
        ProveedorBss bss= new ProveedorBss();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Proveedor p = new Proveedor();
            p.Nombre = textBox1.Text;
            p.Telefono= textBox2.Text;
            p.Direccion= textBox3.Text;
            bss.InsertarProveedorBss(p);
            MessageBox.Show("Se guardo exitosamente");
        }
    }
}
