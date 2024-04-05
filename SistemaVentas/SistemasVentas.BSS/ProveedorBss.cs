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
    public class ProveedorBss
    {
        ProveedorDAL dal = new ProveedorDAL();
        public DataTable ListarProveedorBss()
        {
            return dal.ListarProveedoresDal();
        }
        public void InsertarProveedorBss(Proveedor proveedor)
        {
            dal.InsertarProveedoresDAL(proveedor);
        }
        public Proveedor ObtenerProveedorIdBss(int id)
        {
            return dal.ObtenerProveedoresIdDal(id);
        }

        public void EditarProveedorBss(Proveedor provedor)
        {
            dal.EditarProveedoresDal(provedor);
        }

        public void EliminarProveedorBss(int id)
        {
            dal.EliminarProveedoresDal(id);
        }
        public DataTable ProveedorDatosBSS()
        {
            return dal.ProveedoresDatosDal();
        }

    }
}

