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
    public class DetalleVentaDAL
    {
        DetalleVentaDAL dal = new DetalleVentaDAL();
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarDetalleVentaDAL(DetalleVenta detalleven)
        {
            string consulta = "insert into detalleventa values(" + detalleven.IdVenta + "," +
                                                          "" + detalleven.IdProducto + "," +
                                                          "'" + detalleven.Cantidad + "'," +
                                                          "'" + detalleven.PrecioVenta + "'," +
                                                          "'" + detalleven.SubTotal + "'," +
                                                          "'Exitoso')";
            conexion.Ejecutar(consulta);
        }
        DetalleVenta detalleventa = new DetalleVenta();
        public DetalleVenta ObtenerDetalleVentaIdDal(int id)
        {
            string consulta = "select * from detalleventa where iddetalleventa=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {
                detalleventa.IdDetalleVenta = Convert.ToInt32(tabla.Rows[0]["iddetalleventa"]);
                detalleventa.IdVenta = Convert.ToInt32(tabla.Rows[0]["idventa"]);
                detalleventa.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                detalleventa.Cantidad = Convert.ToInt32(tabla.Rows[0]["cantidad"]);
                detalleventa.PrecioVenta = Convert.ToDecimal(tabla.Rows[0]["precioventa"]);
                detalleventa.SubTotal = Convert.ToDecimal(tabla.Rows[0]["subtotal"]);
                detalleventa.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return detalleventa;
        }
        public void EditarDetalleVDal(DetalleVenta detventa)
        {
            string consulta = "update detalleventa set idventa=" + detventa.IdVenta + "," +
                                                        "idproducto=" + detventa.IdProducto + "," +
                                                        "cantidad=" + detventa.Cantidad + "," +
                                                        "precioventa=" + detventa.PrecioVenta + "," +
                                                        "subtotal=" + detventa.SubTotal + " " +
                                                "where iddetalleventa=" + detventa.IdDetalleVenta;
            conexion.Ejecutar(consulta);
        }
        public void EliminarDetalleVentaDal(int id)
        {
            string consulta = "delete from detalleventa where iddetalleventa=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable DetalleVDatosDal()
        {
            string consulta = " SELECT PRODUCTO.NOMBRE, TIPOPROD.NOMBRE AS Expr1, MARCA.NOMBRE AS Expr2, PROVEEDOR.NOMBRE AS Expr3, PROVEEDOR.TELEFONO, PROVEE.FECHA, PROVEE.PRECIO " +
                               "FROM PROVEE INNER JOIN " +
                               " PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN" +
                               " PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR INNER JOIN" +
                               " MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA INNER JOIN " +
                               " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}