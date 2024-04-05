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
    public class TipoProductoBss
    {
        TipoProductoDAL dal = new TipoProductoDAL();
        public DataTable ListarTipoProductoBss()
        {
            return dal.ListarTipoProductoDal();
        }
        public void InsertarTipoProdBss(TipoProducto tp)
        {
            dal.InsertarTipoProductoDAL(tp);
        }
        public TipoProducto ObtenerTipoProdIdBss(int id)
        {
            return dal.ObtenerTipoProductoIdDal(id);
        }

        public void EditarTipoProdBss(TipoProducto tp)
        {
            dal.EditarTipoProductoDal(tp);
        }

        public void EliminarTipoProdBss(int id)
        {
            dal.EliminarTipoProductoDal(id);
        }

        public DataTable TipoProdDatosBSS()
        {
            return dal.TipoProductoDatosDal();
        }
    }
}
