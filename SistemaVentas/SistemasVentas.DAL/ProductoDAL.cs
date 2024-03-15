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
    public class ProductoDAL
    {
        public DataTable ListarProductoDal()
        {
            string consulta = "select * from producto";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarProductoDal(Producto producto)
        {
            string consulta = "insert into producto values (" + producto.IdTipoProducto + "," +
                                                          "" + producto.IdMarca + "," +
                                                          "'" + producto.Nombre + "'," +
                                                          "'" + producto.CodigoBarras + "'," +
                                                          "'" + producto.Unidad + "'," +
                                                          "'"+producto.Descripcion+"',"+
                                                          "'Activo')";
            conexion.Ejecutar(consulta);

        }
    }
}
