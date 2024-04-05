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
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarTipoProductoDAL (TipoProducto tp)
        {
            string consulta = "insert into TipoProd values('" + tp.Nombre + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public TipoProducto ObtenerTipoProductoIdDal(int id)
        {
            string consulta = "select * from tipoprod where idtipoprod=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            TipoProducto tp = new TipoProducto();
            if (tabla.Rows.Count > 0)
            {
                tp.IdTipoProducto = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                tp.Nombre = tabla.Rows[0]["nombre"].ToString();
                tp.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return tp;

        }


        public void EditarTipoProductoDal(TipoProducto tp)
        {
            string consulta = "update tipoprod set nombre='" + tp.Nombre + "'" +
                                                          "where idtipoprod=" + tp.IdTipoProducto;
            conexion.Ejecutar(consulta);
        }

        public void EliminarTipoProductoDal(int id)
        {
            string consulta = "delete from tipoprod where idtipoprod=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable TipoProductoDatosDal()
        {
            string consulta = " SELECT TIPOPROD.NOMBRE, PRODUCTO.NOMBRE AS Expr1, PRODUCTO.CODIGOBARRA, MARCA.NOMBRE AS Expr2, PRODUCTO.UNIDAD, PRODUCTO.DESCRIPCION" +
                               " FROM TIPOPROD INNER JOIN " +
                               " PRODUCTO ON TIPOPROD.IDTIPOPROD = PRODUCTO.IDTIPOPROD INNER JOIN " +
                               " MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA ";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
