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
    public class UsuarioDAL
    {
        public DataTable ListarUsuariosDal()
        {
            string consulta = "select * from usuario";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarUsuariosDal(Usuario u)
        {
            string consulta = "INSERT INTO USUARIO VALUES (" + u.IdPersona + " , " +
                                                            " '" + u.NombreUser + "' , " +
                                                            " '" + u.Contraeña + "' , " +
                                                            " '" + u.Fecha + "')";
            conexion.Ejecutar(consulta);
        }

        public Usuario ObtenerUsuariosIdDal(int id)
        {
            string consulta = "select * from usuario where idusuario=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Usuario u = new Usuario();
            if (tabla.Rows.Count > 0)
            {
                u.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idusuario"]);
                u.NombreUser = tabla.Rows[0]["nombreuser"].ToString();
                u.Contraeña = tabla.Rows[0]["contraseña"].ToString();
                u.Fecha = Convert.ToDateTime(tabla.Rows[0]["fechareg"]);
            }
            return u;

        }
        public void EditarUsuariosDal(Usuario u)
        {
            string consulta = "update usuario set idpersona=" + u.IdPersona + "," +
                                                                   "nombreuser='" + u.NombreUser + "'," +
                                                                   "contraseña='" + u.Contraeña + "'," +
                                                                   "fechareg='" + u.Fecha + "' " +
                                                           "where idusuario=" + u.IdUsuario;
            conexion.Ejecutar(consulta);
        }

        public void EliminarUsuariosDal(int id)
        {
            string consulta = "delete from usuario where idusuario=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable UsuarioDatosDal()
        {
            string consulta = " SELECT USUARIO.IDUSUARIO, (PERSONA.NOMBRE+' ' +PERSONA.APELLIDO) NOMBRECOMPLETO ,USUARIO.NOMBREUSER, " +
                               " ROL.NOMBRE AS Expr1, USUARIOROL.FECHAASIGNA " +
                               " FROM PERSONA INNER JOIN" +
                               " USUARIO ON PERSONA.IDPERSONA = USUARIO.IDPERSONA INNER JOIN" +
                               " USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO INNER JOIN" +
                               " ROL ON USUARIOROL.IDROL = ROL.IDROL";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
