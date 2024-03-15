using DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProductoDAL
    {
        public DataTable ListarTipoProductoDal()
        {
            string consulta = "select * from tipoprod";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tipoprod");
            return lista;
        }
        public void InsertarTipoProductoDal(TipoProducto tipoProducto)
        {
            string consulta = "insert into tipoprod values ('" + tipoProducto.Nombre + "'," +                                                        
                                                          "'Activo')";
            conexion.Ejecutar(consulta);

        }
    }
}
