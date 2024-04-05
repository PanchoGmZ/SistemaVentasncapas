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
    public class MarcaDAL
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "select * from marca";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarMarcaDAL(Marca mar)
        {
            string consulta = "insert into marca values('" + mar.Nombre + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Marca ObtenerMarcaIdDal(int id)
        {
            string consulta = "select * from marca where idmarca=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Marca marca = new Marca();
            if (tabla.Rows.Count > 0)
            {
                marca.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                marca.Nombre = tabla.Rows[0]["nombre"].ToString();
                marca.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return marca;

        }
        public void EditarMarcaDal(Marca marcas)
        {
            string consulta = "update marca set nombre='" + marcas.Nombre + "'" +
                                                        "where idmarca=" + marcas.IdMarca;
            conexion.Ejecutar(consulta);
        }

        public void EliminarMarcaDal(int id)
        {
            string consulta = "delete from marca where idmarca=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable MarcaDatosDal()
        {
            string consulta = " SELECT MARCA.NOMBRE, PRODUCTO.NOMBRE AS Expr1, PRODUCTO.CODIGOBARRA, PRODUCTO.UNIDAD" +
                               " FROM MARCA INNER JOIN " +
                               " PRODUCTO ON MARCA.IDMARCA = PRODUCTO.IDMARCA ";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
