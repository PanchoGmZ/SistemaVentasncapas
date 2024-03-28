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
    public class ClienteBss
    {
        ClienteDAL dal = new ClienteDAL();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();
        }
        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDal(cliente);
        }
        public Cliente ObtenerIdClienteBss(int id)
        {
            return dal.ObtenerClienteId(id);
        }
        public void EditarClienteBss (Cliente cliente)
        {
            dal.EditarClienteDal(cliente);
        }
        public void EliminarClienteBss (int id)
        {
            dal.EliminarClienteDal (id);
        }
        public DataTable ListarClienteDatosBss ()
        {
           return  dal.ListarClienteDatosDal();
        }
    }
}

