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
    public class VentaBss
    {
        VentaDAL dal = new VentaDAL();
        public DataTable ListarVentaBss()
        {
            return dal.ListarVentasDal();
        }

        public void InsertarVentaBss(Venta v)
        {
            dal.InsertarVentaDAL(v);
        }

        public Venta ObtenerVentaIdBss(int id)
        {
            return dal.ObtenerVentaIdDal(id);
        }
        public void EditarVentaBss(Venta v)
        {
            dal.EditarVentaDal(v);
        }
        public void EliminarVentaBss(int id)
        {
            dal.EliminarVentaDal(id);
        }

        public DataTable VentaDatosBss()
        {
            return dal.VentaDatosDal();
        }
    }
}
