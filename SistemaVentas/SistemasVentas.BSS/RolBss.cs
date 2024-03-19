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
    public class RolBss
    {
        RolDal dal = new RolDal();
        public DataTable ListarRolBss()
        {
            return dal.ListaRolDal();
        }
        public void InsertarRolBss(ROL rol)
        {
            dal.InsertarRolDal(rol);
        }
        public ROL ObtenerROlbss(int id)
        {
            return dal.ObtenerRolId(id);
        }
        public void EditarRolBss(ROL rol)
        {
            dal.EditarROlDal(rol);
        }
        public void EliminarRolBss(int id)
        {
            dal.EliminarROLDal(id);
        }
    }
}
