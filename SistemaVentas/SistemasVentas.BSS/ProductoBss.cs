﻿using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ProductoBss
    {
        ProductoDAL dal = new ProductoDAL();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductoDal();
        }
        public void InsertarProductoBss(Producto producto)
        {
            dal.InsertarProductoDal(producto);
        }
        public DataTable ListarProdDatosBss()
        {
            return dal.ListarProductosDatosDal();
        }
    }
}
