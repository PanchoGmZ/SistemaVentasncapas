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

namespace SistemaVentas.VISTA.MarcaVistas
{
    public partial class MarcaInsertarVistas : Form
    {
        public MarcaInsertarVistas()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            marca.Nombre = txtNombre.Text;
            marca.Estado = txtEstado.Text;

            bss.InsertarMarcaBss(marca);

            MessageBox.Show("Se agrego correctamente esta marca.");
        }
    }
}
