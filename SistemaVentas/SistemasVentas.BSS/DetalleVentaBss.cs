using DAL;
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
    public class DetalleVentaBss
    {
        DetalleVentaDAL DAL = new DetalleVentaDAL();
        public DataTable ListarDetalleVentaBss()
        {
            return DAL.ListarDetalleVentaDal();
        }
        public void InsertarDetalleVentaBss(DetalleVenta detalleventa)
        {
            DAL.InsertarDetalleVentaDAL(detalleventa);
        }
        public DetalleVenta ObtenerDetalleVentaIdBss(int id)
        {
            return DAL.ObtenerDetalleVentaIdDal(id);
        }
        public void EditarDetalleVentaBss(DetalleVenta p)
        {
            DAL.EditarDetalleVDal(p);
        }
        public void EliminarDetalleVentaBss(int id)
        {
            DAL.EliminarDetalleVentaDal(id);
        }
        public DataTable DetalleVentaDatosBSS()
        {
            return DAL.DetalleVDatosDal();
        }
    }
}
