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
    public class IngresoBss
    {
        IngresoDAL dal = new IngresoDAL();
        public DataTable ListarIngresoBss()
        {
            return dal.ListarIngresoDal();
        }
        public void InsertarIngresosBss(Ingreso ingreso)
        {
            dal.InsertarIngresoDAL(ingreso);
        }

        public Ingreso ObtenerIngresosIdBss(int id)
        {
            return dal.ObtenerIngresoIdDal(id);
        }
        public void EditarIngresosBss(Ingreso p)
        {
            dal.EditarIngresoDal(p);
        }
        public void EliminarIngresosBss(int id)
        {
            dal.EliminarIngresoDal(id);
        }

        public DataTable IngresoDatosBSS()
        {
            return dal.IngresoDatosDal();
        }

    }
}

