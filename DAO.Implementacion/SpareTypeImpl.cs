using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Model;
using DAO.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace DAO.Implementacion
{
    public class SpareTypeImpl : ISpareType
    {
        //AQUI AHCEMOS LOS CRUDS SON INDEPEDIENTES DEL UI
        public int Delete(SpareType t)
        {
            string query = @"UPDATE SpareType SET status = 0
                                WHERE idSpareType = @idSpareType";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@idSpareType", t.IdSpareType);
                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SpareType Get(int id)
        {
            SpareType spareType = null;
            string query = @"SELECT*FROM SpareType WHERE idSpareType = @idSpareType";
            SqlCommand sqlCommand = null;
            SqlDataReader sqlDataReader = null;
            try
            {
                //UTILIZANDO UN DATA READER
                sqlCommand = DataBase.CreateBasicCommand(query);
                sqlCommand.Parameters.AddWithValue("@idSpareType", id);
                sqlDataReader =  DataBase.ExecuteDataReaderCommand(sqlCommand);

                while(sqlDataReader.Read())
                {   
                    spareType = new SpareType(byte.Parse(sqlDataReader[0].ToString()), sqlDataReader[1].ToString(), byte.Parse(sqlDataReader[2].ToString()), short.Parse(sqlDataReader[2].ToString()), byte.Parse(sqlDataReader[3].ToString()), DateTime.Parse(sqlDataReader[4].ToString()), DateTime.Parse(sqlDataReader[5].ToString()));
                }   
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                sqlCommand.Clone();
                sqlDataReader.Close();
            }

            return spareType;
        }

        public int Insert(SpareType t)
        {
            string query = @"INSERT INTO SpareType (nameSpareType, idSpareCategory, idEmployee, dateUpdate)
                            VALUES (@nameSpareType, @idSpareCategory, @idEmployee, CURRENT_TIMESTAMP )";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@nameSpareType", t.NameSpareType);
                command.Parameters.AddWithValue("@idSpareCategory", t.IdSpareCategory);
                command.Parameters.AddWithValue("@idEmployee", t.IdEmploye);
                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Select()
        {
            string query = @"SELECT*
                            FROM SpareType
                            WHERE status = 1";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);

                return DataBase.ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Update(SpareType t)
        {
            string query = @"UPDATE SpareType SET  nameSpareType = @nameSpareType, idSpareCategory = @idSpareCategory, idEmployee =@idEmployee, dateUpdate = CURRENT_TIMESTAMP
                                WHERE idSpareType = @idSpareType";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@nameSpareType", t.NameSpareType);
                command.Parameters.AddWithValue("@idSpareCategory", t.IdSpareCategory);
                command.Parameters.AddWithValue("@idEmployee", t.IdEmploye);
                command.Parameters.AddWithValue("@dateUpdate", t.DateUpdate);
                command.Parameters.AddWithValue("@idSpareType", t.IdSpareType);
                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
