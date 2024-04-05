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
    public class ProductoBss
    {
        ProductoDAL dal = new ProductoDAL();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductosDal();
        }
        public void InsertarProductoBss(Producto producto)
        {
            dal.InsertarProductosDAL(producto);
        }

        public Producto ObtenerProductoIdBss(int id)
        {
            return dal.ObtenerProductosIdDal(id);
        }
        public void EditarProductoBss(Producto p)
        {
            dal.EditarProductoDal(p);
        }
        public void EliminarProductoBss(int id)
        {
            dal.EliminarProductosDal(id);
        }
        public DataTable ProductoDatosBss()
        {
            return dal.ProductoDatosDal();
        }
    }
}
