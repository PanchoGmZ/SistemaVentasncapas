﻿using SistemasVentas.DAL;
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
    }
}

