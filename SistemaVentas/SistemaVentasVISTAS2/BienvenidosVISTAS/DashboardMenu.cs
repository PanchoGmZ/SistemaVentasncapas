﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasVISTAS2.BienvenidosVISTAS
{
    public partial class DashboardMenu : Form
    {
        public DashboardMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioDVistas abrir = new UsuarioDVistas();
            abrir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductosDVistas abrirs = new ProductosDVistas();
            abrirs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentasDVistas abrir = new VentasDVistas();
            abrir.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClienteDVistas abrir = new ClienteDVistas();
            abrir.Show();
        }
    }
}
