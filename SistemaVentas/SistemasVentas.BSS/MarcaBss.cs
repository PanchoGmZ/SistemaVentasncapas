using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class MarcaBss
    {
        MarcaDAL DAL = new MarcaDAL();
        public DataTable ListarMarcasBss()
        {
            return DAL.ListarMarcaDal();
        }
        public void InsertarMarcasBss(Marca marca)
        {
            DAL.InsertarMarcaDAL(marca);
        }

        public Marca ObtenerMarcaIdBss(int id)
        {
            return DAL.ObtenerMarcaIdDal(id);
        }

        public void EditarMarcaBss(Marca marcas)
        {
            DAL.EditarMarcaDal(marcas);
        }

        public void EliminarMarcaBss(int id)
        {
            DAL.EliminarMarcaDal(id);
        }

        public DataTable MarcaDatosBSS()
        {
            return DAL.MarcaDatosDal();
        }
    }
}

