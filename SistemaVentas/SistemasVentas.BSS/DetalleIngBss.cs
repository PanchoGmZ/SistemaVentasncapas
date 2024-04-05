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
    public class DetalleIngBss
    {
        DetalleIngDAL dal = new DetalleIngDAL();
        public DataTable ListarDetalleingBss()
        {
            return dal.ListarDetalleIngresoDal();
        }

        public void InsertarDetalleIngBss(DetalleIng DetalleIngreso)
        {
            dal.InsertarDetalleIngresoDAL(DetalleIngreso);
        }
        public DetalleIng ObtenerDetalleIngIdBss(int id)
        {
            return dal.ObtenerDetalleIngresoIdDal(id);
        }
        public void EditarDetalleIngBss(DetalleIng detalleingreso)
        {
            dal.EditarDetalleIngresoDal(detalleingreso);
        }
        public void EliminarDetalleIngresoBss(int id)
        {
            dal.EliminarDetalleIngresoDal(id);
        }

        public DataTable DetalleIngresoDatosBSS()
        {
            return dal.DetalleIngresoDatosDal();
        }
    }
}
