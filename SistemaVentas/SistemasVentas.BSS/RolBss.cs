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
            return dal.ListarRolDal();
        }

        public void InsertarRolBss(ROL R)
        {
            dal.InsertarRolDAL(R);
        }

        public ROL ObtenerRolIdBss(int id)
        {
            return dal.ObtenerRolIdDal(id);
        }

        public void EditarRolBss(ROL r)
        {
            dal.EditarRolDal(r);
        }

        public void EliminarRolBss(int id)
        {
            dal.EliminarRolDal(id);
        }

        public DataTable RolDatosBSS()
        {
            return dal.RolDatosDal();
        }

    }
}
