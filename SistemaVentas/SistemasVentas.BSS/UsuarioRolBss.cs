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
    public class UsuarioRolBss
    {
        UsuarioRolDAL dal = new UsuarioRolDAL();
        public DataTable ListarUsuarioRolBss()
        {
            return dal.ListarUsuariosRolDal();
        }
        public void InsertarUsuarioRolBss(UsuarioRol ur)
        {
            dal.InsertarUsuarioRolDAL(ur);
        }
        public UsuarioRol ObtenerUsuarioRolIdBss(int id)
        {
            return dal.ObtenerUsuarioRolIdDal(id);
        }
        public void EditarUsuarioRolBss(UsuarioRol ur)
        {
            dal.EditarUsuarioRolDal(ur);
        }
        public void EliminarUsuarioRolBss(int id)
        {
            dal.EliminarUsuarioRolDal(id);
        }

        public DataTable UsuarioRolDatosBSS()
        {
            return dal.UsuarioRolDatosDal();
        }
    }
}

