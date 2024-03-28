using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class VentaDAL
    {
        public DataTable ListarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ListarVentasDatosDal()
        {
            string consulta = "SELECT VENTA.IDVENTA, CLIENTE.CODIGOCLIENTE, USUARIO.NOMBREUSER, VENTA.FECHA, VENTA.TOTAL, VENTA.ESTADO\r\nFROM            VENTA INNER JOIN\r\n                         CLIENTE ON VENTA.IDCLIENTE = CLIENTE.IDCLIENTE INNER JOIN\r\n                         USUARIO ON VENTA.IDVENDEDOR = USUARIO.IDUSUARIO INNER JOIN\r\n                         USUARIOROL ON USUARIO.IDUSUARIO = USUARIOROL.IDUSUARIO";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
