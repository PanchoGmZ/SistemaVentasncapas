﻿using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.ClienteVistas
{
    public partial class ListarClienteDatosVISTAS : Form
    {
        public ListarClienteDatosVISTAS()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();

        private void ListarClienteDatosVISTAS_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteDatosBss();
        }
    }
}
