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
    public class ClienteDAL
    {
        public DataTable ListarClienteDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarClienteDAL(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.IdPersona + "," +
                                                          "'" + cliente.TipoCliente + "'," +
                                                          "'" + cliente.CodigoCliente + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Cliente ObtenerClienteIdDal(int id)
        {
            string consulta = "select * from cliente where idcliente=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente clientes = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                clientes.IdCliente = Convert.ToInt32(tabla.Rows[0]["idcliente"]);
                clientes.IdPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                clientes.TipoCliente = tabla.Rows[0]["tipocliente"].ToString();
                clientes.CodigoCliente = tabla.Rows[0]["codigocliente"].ToString();
                clientes.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return clientes;

        }
        public void EditarClienteDal(Cliente clientes)
        {
            string consulta = "update cliente set idpersona=" + clientes.IdPersona + "," +
                                                        "tipocliente='" + clientes.TipoCliente + "'," +
                                                        "codigocliente='" + clientes.CodigoCliente + "'" +
                                                "where idcliente=" + clientes.IdCliente;
            conexion.Ejecutar(consulta);
        }
        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente=" + id;
            conexion.Ejecutar(consulta);
        }

        public DataTable ClienteDatosDal()
        {
            string consulta = " SELECT CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE, (PERSONA.NOMBRE+' ' +PERSONA.APELLIDO) NOMBRECOMPLETO " +
                               " FROM CLIENTE INNER JOIN" +
                               " PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";

            return conexion.EjecutarDataTabla(consulta, "fsdf");

        }
    }
}
