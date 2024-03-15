using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleIngDAL
    {
        public DataTable ListarDetalleIngDal()
        {
            string consulta = "select * from detalleing";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
