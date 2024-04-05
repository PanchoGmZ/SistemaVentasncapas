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
        public DataTable ListarUsuarioBss()
        {
            return dal.ListarUsuariosDal();
        }
        public void InsertarUsuarioBss(Usuario u)
        {
            dal.InsertarUsuariosDal(u);
        }

        public Usuario ObtenerUsuarioIdBss(int id)
        {
            return dal.ObtenerUsuariosIdDal(id);
        }

        public void EditarUsuariosBss(Usuario u)
        {
            dal.EditarUsuariosDal(u);
        }

        public void EliminarUsuariosBss(int id)
        {
            dal.EliminarUsuariosDal(id);
        }

        public DataTable UsuarioDatosBss()
        {
            return dal.UsuarioDatosDal();
        }
    }
}

