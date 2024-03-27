using DAL;
using System;
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
    public partial class BienvenidosVistas : Form
    {
        public BienvenidosVistas()
        {
            InitializeComponent();
        }

        private void BienvenidosVistas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            if (conexion.VerificarCredenciales(usuario, contraseña))
            {
                DashboardMenu abrir = new DashboardMenu();
                abrir.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
