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
    public class DetalleIngDAL
    {
        public DataTable ListarDetalleIngresoDal()
        {
            string consulta = "select * from detalleing";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarDetalleIngresoDAL(DetalleIng detalleingr)
        {
            string consulta = "insert into detalleing values(" + detalleingr.IdIngreso + "," +
                                                          "" + detalleingr.IdProducto + "," +
                                                          "'" + detalleingr.FechaVenc + "'," +
                                                          "'" + detalleingr.Cantidad + "'," +
                                                          "'" + detalleingr.PrecioCosto + "'," +
                                                          "'" + detalleingr.PrecioVenta + "'," +
                                                          "'" + detalleingr.SubTotal + "'," +
                                                          "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
        DetalleIng detalleing = new DetalleIng();
        public DetalleIng ObtenerDetalleIngresoIdDal(int id)
        {
            string consulta = "select * from detalleing where iddetalleing=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                detalleing.IdDetalleIng = Convert.ToInt32(tabla.Rows[0]["iddetalleing"]);
                detalleing.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                detalleing.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                detalleing.FechaVenc = Convert.ToDateTime(tabla.Rows[0]["fechavenc"]);
                detalleing.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleing.PrecioCosto = Convert.ToDecimal(tabla.Rows[0]["preciocosto"]);
                detalleing.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                detalleing.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                detalleing.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return detalleing;
        }
        public void EditarDetalleIngresoDal(DetalleIng detalleingresos)
        {
            string consulta = "update detalleing set idingreso=" + detalleingresos.IdIngreso + "," +
                                                        "idproducto=" + detalleingresos.IdProducto + "," +
                                                        "fechavenc='" + detalleingresos.FechaVenc + "'," +
                                                        "cantidad=" + detalleingresos.Cantidad + "," +
                                                        "preciocosto=" + detalleingresos.PrecioCosto + "," +
                                                        "precioventa=" + detalleingresos.PrecioVenta + "," +
                                                        "subtotal=" + detalleingresos.SubTotal + " " +
                                                "where iddetalleing=" + detalleingresos.IdDetalleIng;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleIngresoDal(int id)
        {
            string consulta = "delete from detalleing where iddetalleing=" + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable DetalleIngresoDatosDal()
        {
            string consulta = " SELECT PROVEEDOR.NOMBRE, PROVEEDOR.TELEFONO, PRODUCTO.NOMBRE AS Expr1, MARCA.NOMBRE AS Expr2, " +
                               " TIPOPROD.NOMBRE AS Expr3, INGRESO.TOTAL, DETALLEING.FECHAVENC, DETALLEING.CANTIDAD, " +
                               " DETALLEING.PRECIOCOSTO, DETALLEING.PRECIOVENTA, DETALLEING.SUBTOTAL" +
                               " FROM DETALLEING INNER JOIN" +
                               " INGRESO ON DETALLEING.IDINGRESO = INGRESO.IDINGRESO INNER JOIN" +
                               " PRODUCTO ON DETALLEING.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN" +
                               " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD INNER JOIN" +
                               " MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA INNER JOIN" +
                               " PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
