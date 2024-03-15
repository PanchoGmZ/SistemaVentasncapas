using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class UsuarioBss
    {
        UsuarioDAL dal = new UsuarioDAL();
        public DataTable ListarUsuariosBss()
        {
            return dal.ListarUsuariosDal();
        }
        public void InsertarUsuarioBss(Usuario usuario)
        {
            dal.InsertarUsuarioDal(usuario);
        }
    }
}

