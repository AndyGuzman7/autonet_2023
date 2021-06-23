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
    public class SpareImpl : ISpare
    {
        public int Delete(Spare t)
        {
            string query = @"UPDATE Spare SET status = 0
                                WHERE idSpare = @idSpare";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@idSpare", t.IdSpare);
                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(Spare t)
        {
            string query = @"INSERT INTO Spare (description, 'nameProduct', currentBalance, basePrice,    weight, productCode, idFactory, idSpareType, idEmployee, dateUpdate)
                                            VALUES (@description, @nameProduct, @currentBalance, @basePrice, @weight, @productCode, @idFactory ,@idSpareType, @idEmployee, CURRENT_TIMESTAMP )";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@description", t.Description);
                command.Parameters.AddWithValue("@nameProduct", t.NameProduct);
                command.Parameters.AddWithValue("@currentBalance", t.CurrentBalance);
                command.Parameters.AddWithValue("@basePrice", t.BasePrice);
                command.Parameters.AddWithValue("@weight", t.Weight);
                command.Parameters.AddWithValue("@productCode", t.ProductCode);
                command.Parameters.AddWithValue("@idFactory", t.IdFactory);
                command.Parameters.AddWithValue("@idSpareType", t.IdSpareType);
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
                            FROM Spare
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

        public int Update(Spare t)
        {
            string query = @"UPDATE Spare SET  description = @description, nameProduct = @nameProduct, currentBalance = @currentBalance, basePrice = @basePrice,    weight = @weight, productCode = @productCode, idFactory = @idFactory, idSpareType = @idSpareType, idEmployee = @idEmployee, dateUpdate = CURRENT_TIMESTAMP
                                WHERE idSpare = @idSpare";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@description", t.Description);
                command.Parameters.AddWithValue("@nameProduct", t.NameProduct);
                command.Parameters.AddWithValue("@currentBalance", t.CurrentBalance);
                command.Parameters.AddWithValue("@basePrice", t.BasePrice);
                command.Parameters.AddWithValue("@weight", t.Weight);
                command.Parameters.AddWithValue("@productCode", t.ProductCode);
                command.Parameters.AddWithValue("@idFactory", t.IdFactory);
                command.Parameters.AddWithValue("@idSpareType", t.IdSpareType);
                command.Parameters.AddWithValue("@idEmployee", t.IdEmploye);
                command.Parameters.AddWithValue("@idSpare", t.IdSpare);
                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
