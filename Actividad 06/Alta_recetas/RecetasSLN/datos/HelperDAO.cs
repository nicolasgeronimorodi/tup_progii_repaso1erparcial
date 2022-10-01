using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using RecetasSLN.dominio;

namespace RecetasSLN.datos
{
    internal class HelperDAO
    {
        private static HelperDAO instancia;
        private string cadenaConexion;
        private SqlConnection cnn;


        private HelperDAO()
        {
            cadenaConexion = Properties.Resources.cnnString;
            cnn=new SqlConnection(cadenaConexion);

        }

        public static HelperDAO obtenerInstancia()
        {
            if(instancia==null)
                instancia = new HelperDAO();
            return instancia;
        }

        public DataTable consultarDB(string nombreSP )
        {
            SqlCommand cmd = new SqlCommand();
            DataTable tabla=new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();
            return tabla;

        }

        public int consultarEscalar(string nombreSP, string nombreParam)
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType=CommandType.StoredProcedure;    
            cmd.CommandText = nombreSP;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName= nombreParam;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            try
            {
                int check= (int)pOut.Value;
            }
            catch (Exception)
            {

                return 1;
            }


            cnn.Close();
            return Convert.ToInt32(pOut.Value);
       
        
        
        }

        public bool confirmarTransaccionReceta(dominio.Receta receta)
        {
            bool ok = false ;
            SqlTransaction trs = null;

            try
            {
                cnn.Open();
                trs = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();
                cmd.Transaction = trs;

                cmd.Connection = cnn;
                cmd.CommandText = "SP_INSERTAR_RECETA";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", receta.Nombre);
                cmd.Parameters.AddWithValue("@cheff", receta.Chef);
                cmd.Parameters.AddWithValue("@tipo_receta", receta.TipoReceta);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@id_receta";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);

                cmd.ExecuteNonQuery();
                int idReceta;

                
                try
                {
                      idReceta = (int)pOut.Value;
                }
                catch (Exception)
                {
                      idReceta = 1;
                 
                    
                }
                
                //int idReceta = (int)pOut.Value;

                SqlCommand cmdDetalle;


                /*
                  Si fuera una tabla detalle con pk no identity
                 Tendría que tener un:

                int id_detalle=1; 
                e incrementarlo al final del foreach
                 
                 */

                foreach (DetalleReceta detalle in receta.Detalles)
                    
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", cnn, trs);
                    cmdDetalle.CommandType=CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_receta", idReceta);
                    cmdDetalle.Parameters.AddWithValue("@id_ingrediente", detalle.Ingrediente.IngredienteId);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                    cmdDetalle.ExecuteNonQuery();

                    //id_detalle++
                }

                trs.Commit();
                ok = true;

            }
            catch (Exception)
            {
                if(trs!=null)
                    trs.Rollback();

                throw new Exception("Error en inserción base de datos");
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return ok;




        }
    }
}
