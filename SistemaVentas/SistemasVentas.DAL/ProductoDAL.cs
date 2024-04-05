﻿using DAL;
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
        public DataTable ListarProductosDal()
        {
            string consulta = "select * from producto";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarProductosDAL(Producto prod)
        {
            string consulta = "insert into producto values(" + prod.IdTipoProducto + "," +
                                                          "" + prod.IdMarca + "," +
                                                          "'" + prod.Nombre + "'," +
                                                          "'" + prod.CodigoBarras + "'," +
                                                          "'" + prod.Unidad + "'," +
                                                          "'" + prod.Descripcion + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Producto ObtenerProductosIdDal(int id)
        {
            string consulta = "select * from producto where idproducto=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Producto p = new Producto();
            if (tabla.Rows.Count > 0)
            {
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.IdTipoProducto = Convert.ToInt32(tabla.Rows[0]["idtipoprod"]);
                p.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.CodigoBarras = tabla.Rows[0]["codigobarra"].ToString();
                p.Unidad = Convert.ToInt32(tabla.Rows[0]["unidad"]);
                p.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;

        }

        public void EditarProductoDal(Producto prod)
        {
            string consulta = "update producto set idtipoprod=" + prod.IdTipoProducto + "," +
                                                        "idmarca=" + prod.IdMarca + "," +
                                                        "nombre='" + prod.Nombre + "'," +
                                                        "codigobarra='" + prod.CodigoBarras + "'," +
                                                        "unidad=" + prod.Unidad + "," +
                                                        "descripcion='" + prod.Descripcion + "'," +
                                                        "estado='" + prod.Estado + "' " +
                                                "where idproducto=" + prod.IdProducto;
            conexion.Ejecutar(consulta);
        }
        public void EliminarProductosDal(int id)
        {
            string consulta = "delete from producto where idproducto=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable ProductoDatosDal()
        {
            string consulta = " SELECT TIPOPROD.NOMBRE, MARCA.NOMBRE AS Expr1, PRODUCTO.NOMBRE AS Expr2,  " +
                               " PRODUCTO.CODIGOBARRA, PRODUCTO.UNIDAD, PRODUCTO.DESCRIPCION" +
                               " FROM PRODUCTO INNER JOIN" +
                               " TIPOPROD ON PRODUCTO.IDTIPOPROD = TIPOPROD.IDTIPOPROD INNER JOIN" +
                               "  MARCA ON PRODUCTO.IDMARCA = MARCA.IDMARCA";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
