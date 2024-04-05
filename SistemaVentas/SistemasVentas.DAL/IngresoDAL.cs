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
    public class IngresoDAL
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from ingreso";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarIngresoDAL(Ingreso i)
        {
            string consulta = "insert into ingreso values(" + i.IdProvedor + "," +
                                                          "'" + i.FechaIngreso + "'," +
                                                          "'" + i.Total + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Ingreso ObtenerIngresoIdDal(int id)
        {
            string consulta = "select * from ingreso where idingreso=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Ingreso i = new Ingreso();
            if (tabla.Rows.Count > 0)
            {
                i.IdIngreso = Convert.ToInt32(tabla.Rows[0]["idingreso"]);
                i.IdProvedor = Convert.ToInt32(tabla.Rows[0]["idproveedor"]);
                i.FechaIngreso = Convert.ToDateTime(tabla.Rows[0]["fechaingreso"]);
                i.Total = Convert.ToInt32(tabla.Rows[0]["total"]);
                i.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return i;

        }
        public void EditarIngresoDal(Ingreso i)
        {
            string consulta = "update ingreso set idproveedor=" + i.IdProvedor + "," +
                                                        "fechaingreso='" + i.FechaIngreso + "'," +
                                                        "total=" + i.Total + "," +
                                                        "estado='" + i.Estado + "' " +
                                                        "where idingreso=" + i.IdIngreso;
            conexion.Ejecutar(consulta);
        }
        public void EliminarIngresoDal(int id)
        {
            string consulta = "delete from ingreso where idingreso=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable IngresoDatosDal()
        {
            string consulta = " SELECT PROVEEDOR.NOMBRE, PROVEEDOR.TELEFONO, INGRESO.FECHAINGRESO, INGRESO.TOTAL" +
                               " FROM INGRESO INNER JOIN " +
                               " PROVEEDOR ON INGRESO.IDPROVEEDOR = PROVEEDOR.IDPROVEEDOR";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }

    }
}
