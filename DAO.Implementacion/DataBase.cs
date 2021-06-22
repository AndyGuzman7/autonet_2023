using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO.Implementacion
{
    class DataBase
    {
        private static string connectionString = @"data source = localhost\SQLEXPRESS; initial catalog = BDDAUTONET; user id= root; password=Univalle2";
        public static SqlCommand CreateBasicCommand()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }
        public static SqlCommand CreateBasicCommand(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query);
            command.Connection = connection;
            return command;
        }

        /// <summary>
        /// Insert, Update, Delete
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static int ExecuteBasicCommand(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
            finally
            {
                command.Connection.Close();
            }
        }

        /// <summary>
        /// Select
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTableCommand(SqlCommand command)
        {
            DataTable res = new DataTable();
            try
            {
                command.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(res);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
            return res;
            //DADTA READER LEE LOS DATOS, APUTNA AL SELECT, VA FILA POR FILA, SE VA APODER VE ROS CAMBIOS
        }





        /// <summary>
        /// SELECT CON DATAREADER
        /// </summary>
        /// <param name="sqlCommand"></param>
        /// <returns></returns>

        public static SqlDataReader ExecuteDataReaderCommand(SqlCommand sqlCommand)
        {
            SqlDataReader dr = null; // esto retornamos
            try
            {
                sqlCommand.Connection.Open();
                dr = sqlCommand.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            //no nesecita un finally porque lee uno por uno
            return dr;
        }

    }
}
