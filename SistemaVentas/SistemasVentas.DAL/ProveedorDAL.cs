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
    public class ProveedorDAL
    {
        public DataTable ListarProveedoresDal()
        {
            string consulta = "select * from proveedor";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProveedoresDAL(Proveedor pr)
        {
            string consulta = "insert into proveedor values('" + pr.Nombre + "'," +
                                                            "'" + pr.Telefono + "'," +
                                                            "'" + pr.Direccion + "'," +
                                                            "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Proveedor ObtenerProveedoresIdDal(int id)
        {
            string consulta = "select * from proveedor where idproveedor=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Proveedor pr = new Proveedor();
            if (tabla.Rows.Count > 0)
            {
                pr.IdProveedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                pr.Nombre = tabla.Rows[0]["nombre"].ToString();
                pr.Telefono = tabla.Rows[0]["telefono"].ToString();
                pr.Direccion = tabla.Rows[0]["direccion"].ToString();
                pr.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return pr;
        }


        public void EditarProveedoresDal(Proveedor pr)
        {
            string consulta = "update proveedor set nombre='" + pr.Nombre + "'," +
                                                        "telefono='" + pr.Telefono + "'," +
                                                        "direccion='" + pr.Direccion + "'" +
                                                        "where idproveedor=" + pr.IdProveedor;
            conexion.Ejecutar(consulta);
        }

        public void EliminarProveedoresDal(int id)
        {
            string consulta = "delete from proveedor where idproveedor=" + id;
            conexion.Ejecutar(consulta);
        }
        public DataTable ProveedoresDatosDal()
        {
            string consulta = " SELECT        PROVEEDOR.NOMBRE, PROVEEDOR.TELEFONO, PROVEE.PRECIO, PRODUCTO.NOMBRE AS Expr1" +
                               " FROM            PROVEEDOR INNER JOIN " +
                               " PROVEE ON PROVEEDOR.IDPROVEEDOR = PROVEE.IDPROVEEDOR INNER JOIN" +
                               "  PRODUCTO ON PROVEE.IDPRODUCTO = PRODUCTO.IDPRODUCTO";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
