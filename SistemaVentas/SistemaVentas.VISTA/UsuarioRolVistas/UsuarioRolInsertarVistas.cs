using SistemasVentas.BSS;
using SistemasVentas.Modelos;
using SistemaVentas.VISTA.RolVistas;
using SistemaVentas.VISTA.UsuarioVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolInsertarVistas : Form
    {
        public UsuarioRolInsertarVistas()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        public static int IdUsuarioSeleccionado = 0;
        UsuarioBss bssu = new UsuarioBss();
        public static int IdRolSeleccionado = 0;
        RolBss bssr = new RolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol usuarioRol = new UsuarioRol();
            usuarioRol.IdUsuario = IdUsuarioSeleccionado;
            usuarioRol.IdRol = IdRolSeleccionado;
            usuarioRol.FechaAsigna = dateTimePicker1.Value;
            usuarioRol.Estado = txtEstado.Text;

            bss.InsertarUsuarioRolBss(usuarioRol);

            MessageBox.Show("Se agrego correctamente este UsuarioRol.");
        }

        private void btnSelecTiProd_Click(object sender, EventArgs e)
        {
 
            }
        }

    }



