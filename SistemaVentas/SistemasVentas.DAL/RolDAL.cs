
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
    public class RolDal
    {
        public DataTable ListarRolDal()
        {
            string consulta = "select * from rol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarRolDAL(ROL R)
        {
            string consulta = "insert into rol values('" + R.Nombre + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public ROL ObtenerRolIdDal(int id)
        {
            string consulta = "select * from rol where idrol=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            ROL r = new ROL();
            if (tabla.Rows.Count > 0)
            {
                r.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                r.Nombre = tabla.Rows[0]["nombre"].ToString();
                r.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return r;

        }

        public void EditarRolDal(ROL R)
        {
            string consulta = "update rol set nombre='" + R.Nombre + "' " +
                                 "where idrol=" + R.IdRol;
            conexion.Ejecutar(consulta);
        }

        public void EliminarRolDal(int id)
        {
            string consulta = "delete from rol where idrol=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable RolDatosDal()
        {
            string consulta = " SELECT (ROL.NOMBRE) ROL, USUARIO.NOMBREUSER, USUARIO.CONTRASEÑA " +
                               " FROM ROL CROSS JOIN" +
                               " USUARIO";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
