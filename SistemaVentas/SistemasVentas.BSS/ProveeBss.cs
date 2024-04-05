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
    public class ProveeBss
    {
        ProveeDAL DAL = new ProveeDAL();
        public DataTable ListarProveeBss()
        {
            return DAL.ListarProveeDal();
        }
        public void InsertarProveeBss(Provee provee)
        {
            DAL.InsertarProveeDAL(provee);
        }
        public Provee ObtenerProveeIdBss(int id)
        {
            return DAL.ObtenerProveeIdDal(id);
        }
        public void EditarProveeBss(Provee p)
        {
            DAL.EditarProveeDal(p);
        }
        public void EliminarProveeBss(int id)
        {
            DAL.EliminarProveeDal(id);
        }
        public DataTable ProveeDatosBSS()
        {
            return DAL.ProveeDatosDal();
        }
    }
}
