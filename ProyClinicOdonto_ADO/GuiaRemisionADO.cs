using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyClinicOdonto_BE;

namespace ProyClinicOdonto_ADO
{
    public class GuiaRemisionADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public GuiaRemisionVistaBE ConsultarGuia(string strCodigo)
        {
            GuiaRemisionVistaBE objGuiaRemisionVistaBE = new GuiaRemisionVistaBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ConsultarGuia";
            cmd.Parameters.Clear();

            try
            {
                cmd.Parameters.AddWithValue("@idequipo", strCodigo);
                // Abrimos la conexión y ejecutamos
                cnx.Open();
                dtr = cmd.ExecuteReader();

                // Verificamos si se devolvieron resultados
                if (dtr.HasRows)
                {
                    dtr.Read();
                    objGuiaRemisionVistaBE.NumGuia = dtr["num_guia"].ToString();
                    objGuiaRemisionVistaBE.FechaEmision = Convert.ToDateTime(dtr["fecha_emision"]);
                    objGuiaRemisionVistaBE.FechaPartida = Convert.ToDateTime(dtr["fecha_partida"]);
                    objGuiaRemisionVistaBE.FechaLlegada = Convert.ToDateTime(dtr["fecha_llegada"]);
                    objGuiaRemisionVistaBE.Proveedor = dtr["proveedor"].ToString();
                    objGuiaRemisionVistaBE.Ruc = dtr["ruc"].ToString();
                    objGuiaRemisionVistaBE.Telefono = dtr["telefono"].ToString();
                    objGuiaRemisionVistaBE.Direccion = dtr["direccion"].ToString();
                    objGuiaRemisionVistaBE.IdDist = dtr["IdDist"].ToString();
                    objGuiaRemisionVistaBE.NombreDistrito = dtr["nombre_distrito"].ToString();
                    objGuiaRemisionVistaBE.Idequipo = dtr["idequipo"].ToString();
                    objGuiaRemisionVistaBE.NombreEquipo = dtr["nombre_equipo"].ToString();
                    objGuiaRemisionVistaBE.UdMedidaDescripcion = dtr["udmedida_descripcion"].ToString();
                    objGuiaRemisionVistaBE.Cantidad = dtr["cantidad"].ToString();
                }

                dtr.Close();
                return objGuiaRemisionVistaBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean InsertarGuia(GuiaRemisionBE objGuiaRemisionBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarGuiaRemision";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha_emision", objGuiaRemisionBE.FechaEmision);
                cmd.Parameters.AddWithValue("@fecha_partida", objGuiaRemisionBE.FechaPartida);
                cmd.Parameters.AddWithValue("@fecha_llegada", objGuiaRemisionBE.FechaLlegada);
                cmd.Parameters.AddWithValue("@proveedor", objGuiaRemisionBE.Proveedor);
                cmd.Parameters.AddWithValue("@ruc", objGuiaRemisionBE.Ruc);
                cmd.Parameters.AddWithValue("@telefono", objGuiaRemisionBE.Telefono);
                cmd.Parameters.AddWithValue("@direccion", objGuiaRemisionBE.Direccion);
                cmd.Parameters.AddWithValue("@IdDist", objGuiaRemisionBE.IdDist);
                cmd.Parameters.AddWithValue("@idequipo", objGuiaRemisionBE.Idequipo);
                cmd.Parameters.AddWithValue("@udmedida_descripcion", objGuiaRemisionBE.UdMedidaDescripcion);
                cmd.Parameters.AddWithValue("@cantidad", objGuiaRemisionBE.Cantidad);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }
    }
}
