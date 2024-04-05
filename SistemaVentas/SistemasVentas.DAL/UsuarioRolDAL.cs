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
    public class UsuarioRolDAL
    {
        public DataTable ListarUsuariosRolDal()
        {
            string consulta = "select * from usuariorol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarUsuarioRolDAL(UsuarioRol usuarioRol)
        {
            string consulta = "insert into usuariorol values(" + usuarioRol.IdUsuario + "," +
                                                          "'" + usuarioRol.IdRol + "'," +
                                                          "'" + usuarioRol.FechaAsig + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }
        UsuarioRol ur = new UsuarioRol();
        public UsuarioRol ObtenerUsuarioRolIdDal(int id)
        {
            string consulta = "select * from usuariorol where idusuariorol=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            if (tabla.Rows.Count > 0)
            {

                ur.IdUsuarioRol = Convert.ToInt32(tabla.Rows[0]["idusuariorol"]);
                ur.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                ur.IdRol = Convert.ToInt32(tabla.Rows[0]["idrol"]);
                ur.FechaAsig = Convert.ToDateTime(tabla.Rows[0]["fechaasigna"]);
                ur.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return ur;
        }
        public void EditarUsuarioRolDal(UsuarioRol p)
        {
            string consulta = "update usuariorol set idusuario=" + p.IdUsuario + "," +
                                                        "idrol=" + p.IdRol + "," +
                                                        "fechaasigna='" + p.FechaAsig + "', " +
                                                        "estado='" + p.Estado + "' " +
                                                "where idusuariorol=" + p.IdUsuarioRol;
            conexion.Ejecutar(consulta);
        }
        public void EliminarUsuarioRolDal(int id)
        {
            string consulta = "delete from usuariorol where idusuariorol=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable UsuarioRolDatosDal()
        {
            string consulta = " SELECT USUARIOROL.FECHAASIGNA, USUARIO.CONTRASEÑA, USUARIO.NOMBREUSER, ROL.NOMBRE " +
                               "FROM USUARIOROL INNER JOIN" +
                               " USUARIO ON USUARIOROL.IDUSUARIO = USUARIO.IDUSUARIO INNER JOIN " +
                               "ROL ON USUARIOROL.IDROL = ROL.IDROL";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }   
}
