﻿using SistemasVentas.
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
        public DataTable ListaRolDal()
        {
            string consulta = "select * from rol";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "Rol");
            return lista;
        }
   
        public void InsertarRolDal(ROL rol)
        {
            string consulta = "insert into rol values ('" +rol.Nombre+"',"+
                                                          "'Activo')";
            conexion.Ejecutar(consulta);

        }
    }
}
