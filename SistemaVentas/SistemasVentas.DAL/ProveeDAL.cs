using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveeDal
    {
        public DataTable ListarProveeDal()
        {
            string consulta = "SELECT PROVEE.IDPROVEE, PRODUCTO.NOMBRE AS PRODUCTO, " +
                                "PROVEEDOR.NOMBRE AS PROVEEDOR, PROVEE.FECHA, PROVEE.PRECIO\r\n" +
                                "FROM     PROVEE INNER JOIN\r\n                  " +
                                "PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO INNER JOIN\r\n                  " +
                                "PROVEEDOR ON PROVEE.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProveeDal(Provee provee)
        {
            string consulta = "insert into provee values(" + provee.IdProducto + "," +
                                                            "" + provee.IdProveedor + "," +
                                                            "'" + provee.Fecha + "'," +
                                                            "" + provee.Precio + ")";
            conexion.Ejecutar(consulta);
        }
        public Provee ObtenerProveeIdDal(int id)
        {
            string consulta = "select * from provee where idprovee=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Provee provee = new Provee();
            if (tabla.Rows.Count > 0)
            {
                provee.IdProvee = Convert.ToInt32(tabla.Rows[0]["idprovee"]);
                provee.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                provee.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                provee.Fecha = Convert.ToDateTime(tabla.Rows[0]["fecha"]);
                provee.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
            }
            return provee;
        }
        public void EditarProveeDal(Provee provee)
        {
            string consulta = "update provee set idproducto=" + provee.IdProducto + "," +
                                                        "idproveedor=" + provee.IdProveedor + "," +
                                                        "fecha='" + provee.Fecha + "'," +
                                                        "precio=" + provee.Precio + " " +
                                                "where idprovee=" + provee.IdProvee;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProveeDal(int id)
        {
            string consulta = "delete from provee where idprovee=" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
