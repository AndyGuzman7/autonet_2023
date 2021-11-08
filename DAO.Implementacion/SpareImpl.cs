using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO.Model;
using DAO.Interfaces;
using System.Data;
using System.Data.SqlClient;
using Strategys;

namespace DAO.Implementacion
{

    public class SpareImpl : ISpare
    {
        LogWrite logWrite = new LogWrite("Spare", Session.IdSession);
        
       
        public int Delete(Spare t)
        {
            logWrite.NameMethod = "Delete";
            int rest = 0;
            string query = @"UPDATE Spare SET status = 0
                                WHERE idSpare = @idSpare";
            try
            {
                logWrite.MensajeInicio();
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@idSpare", t.IdSpare);
                rest = DataBase.ExecuteBasicCommand(command);
                logWrite.MensajeFinalizado();
            }
            catch (Exception ex)
            {
                logWrite.MensajeError(ex);
            }
            return rest;
        }

        public int Insert(Spare t)
        {
            logWrite.NameMethod = "Insert";
            int rest = 0;
            string query = @"INSERT INTO Spare (description, nameProduct, currentBalance, basePrice,    weight, productCode, idFactory, idSpareType, idEmployee, dateUpdate)
                                            VALUES (@description, @nameProduct, @currentBalance, @basePrice, @weight, @productCode, @idFactory ,@idSpareType, @idEmployee, CURRENT_TIMESTAMP )";
            try
            {
                logWrite.MensajeInicio();
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
                
                rest = DataBase.ExecuteBasicCommand(command);
                logWrite.MensajeFinalizado();
            }
            catch (Exception ex)
            {
                logWrite.MensajeError(ex);
            }
            return rest;
        }

        public DataTable Select()
        {
            logWrite.NameMethod = "Select";
            string query = @"SELECT*
                            FROM Spare
                            WHERE status = 1";
            DataTable dt = new DataTable();
            try
            {
                logWrite.MensajeInicio();
                SqlCommand command = DataBase.CreateBasicCommand(query);
          
                dt = DataBase.ExecuteDataTableCommand(command);
                logWrite.MensajeFinalizado();
              
            }
            catch (Exception ex)
            {
                logWrite.MensajeError(ex);
            }
            return dt;
        }

        public DataTable SelectLike(string cadenaBuscar)
        {
            logWrite.NameMethod = "SelectLike";
            string query = @"SELECT*
                            FROM Spare
                            WHERE status = 1 AND nameProduct LIKE @cadenaBuscar";
            // WHERE status = 1 AND ((SELECT CHARINDEX( @cadenaBuscar, nameProduct)) >= 1 OR @cadenaBuscar = ' ')";
            DataTable dt = new DataTable();
            //SELECT CHARINDEX ('ZUR', primerApellido)) >= 1
            try
            {
                logWrite.MensajeInicio();
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@cadenaBuscar", $"%{cadenaBuscar}%");

                dt = DataBase.ExecuteDataTableCommand(command);
                logWrite.MensajeFinalizado();

            }
            catch (Exception ex)
            {
                logWrite.MensajeError(ex);
            }
            return dt;
        }

        public int Update(Spare t)
        {
            logWrite.NameMethod = "Update";
            int rest = 0;
            string query = @"UPDATE Spare SET  description = @description, nameProduct = @nameProduct, currentBalance = @currentBalance, basePrice = @basePrice,    weight = @weight, productCode = @productCode, idFactory = @idFactory, idSpareType = @idSpareType, idEmployee = @idEmployee, dateUpdate = CURRENT_TIMESTAMP
                                WHERE idSpare = @idSpare";
            try
            {
                logWrite.MensajeInicio();
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
                rest = DataBase.ExecuteBasicCommand(command);
                logWrite.MensajeFinalizado();
            }
            catch (Exception ex)
            {
                logWrite.MensajeError(ex);
            }
            return rest;
        }
    }
}
