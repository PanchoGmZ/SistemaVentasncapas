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

namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    public partial class UsuarioRolEditarVISTAS : Form
    {
        int idx = 0;
        UsuarioRol r = new UsuarioRol();
        UsuarioRolBSS bss = new UsuarioRolBSS();
        UsuarioBSS bssuser = new UsuarioBSS();
        RolBss bssrol = new RolBss();
        public static int IdUsuarioSeleccionada = 0;
        public static int IdRolSeleccionada = 0;
        public UsuarioRolEditarVista(int id)
        public UsuarioRolEditarVISTAS()
        {
            InitializeComponent();
        }
    }
}
