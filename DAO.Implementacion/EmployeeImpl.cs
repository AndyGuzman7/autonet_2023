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
    public class EmployeeImpl : IEmployee
    {
        public int Delete(Employeee t)
        {
            string query = @"UPDATE Employee SET status = 0
                                WHERE idEmployee = @idEmployye";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@idEmployye", t.IdEmployee);
                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Insert(Employeee t)
        {
            string query = @"INSERT INTO Employee(nameUser, password, UserType, idEmployeAdd, firstName, lastName, birthDate, [Address], phone, gender, dateUpdate, email, ci)
                                           VALUES(@nameUser, HASHBYTES('md5',@password), @UserType, @idEmployeAdd, @firstName, @lastName, @birthDate, @Address, @phone, @gender, CURRENT_TIMESTAMP, @email, @ci)";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@nameUser", t.NameUser);
                command.Parameters.AddWithValue("@password", t.Password).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@UserType", t.UserType);
                command.Parameters.AddWithValue("@idEmployeAdd", t.IdEmploye);
                command.Parameters.AddWithValue("@firstName", t.FirstName);
                command.Parameters.AddWithValue("@lastName", t.LastName);
                command.Parameters.AddWithValue("@birthDate", t.BirthDate);
                command.Parameters.AddWithValue("@Address", t.Address);
                command.Parameters.AddWithValue("@phone", t.Phone);
                command.Parameters.AddWithValue("@gender", t.Gender);
                command.Parameters.AddWithValue("@email", t.Email);
                command.Parameters.AddWithValue("@ci", t.Ci);


                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Login(string userName, string password)
        {
            try
            {
                string query = @"SELECT idEmployee, nameUser, UserType, registrationDate, dateUpdate
                            FROM Employee
                            WHERE status = 1 AND nameUser = @nameUser AND password = HASHBYTES('md5',@password)";

                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@nameUser", userName);
                command.Parameters.AddWithValue("@password", password).SqlDbType = SqlDbType.VarChar;
                return DataBase.ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable CompareEmail(string email)
        {
            string query = @"SELECT*
                            FROM Employee
                            WHERE status = 1 AND email = @email";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@email", email);

                return DataBase.ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable Select()
        {
            string query = @"SELECT*
                            FROM Employee
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

        public int Update(Employeee t)
        {
            string query = @"UPDATE Employee SET nameUser = @nameUser,
                            password =  HASHBYTES('md5',@password),
                            UserType = @UserType,
                            idEmployeAdd = @idEmployeAdd,
                            firstName = @firstName,
                            lastName = @lastName,
                            birthDate = @birthDate, 
                            [Address] =  @Address,
                            phone = @phone,
                            gender = @gender,
                            dateUpdate = CURRENT_TIMESTAMP,
                            email = @email,
                            ci = @ci
                            WHERE idEmployee = @idEmployee AND status = 1;";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@nameUser", t.NameUser);
                command.Parameters.AddWithValue("@password", t.Password).SqlDbType = SqlDbType.VarChar;
                command.Parameters.AddWithValue("@UserType", t.UserType);
                command.Parameters.AddWithValue("@idEmployeAdd", t.IdEmploye);
                command.Parameters.AddWithValue("@firstName", t.FirstName);
                command.Parameters.AddWithValue("@lastName", t.LastName);
                command.Parameters.AddWithValue("@birthDate", t.BirthDate);
                command.Parameters.AddWithValue("@Address", t.Address);
                command.Parameters.AddWithValue("@phone", t.Phone);
                command.Parameters.AddWithValue("@gender", t.Gender);
                command.Parameters.AddWithValue("@email", t.Email);
                command.Parameters.AddWithValue("@idEmployee", t.IdEmployee);
                command.Parameters.AddWithValue("@ci", t.Ci);
                return DataBase.ExecuteBasicCommand(command);
               

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateRestorePassword(string email, string password)
        {
            string query = @"UPDATE Employee SET password = HASHBYTES('md5',@password)
                            WHERE email = @email AND status = 1;";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@password", password).SqlDbType = SqlDbType.VarChar;
                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetId(int id)
        {
            string query = @"SELECT registrationDate, dateUpdate
                            FROM Employee
                            WHERE status = 1 AND idEmployee = @idEmployee  ";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@idEmployee", id);
                return DataBase.ExecuteDataTableCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int UpdatePassword(string password, int id)
        {
            string query = @"UPDATE Employee SET password = HASHBYTES('md5',@password), dateUpdate = CURRENT_TIMESTAMP
                            WHERE idEmployee = @idEmployee AND status = 1";
            try
            {
                SqlCommand command = DataBase.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@idEmployee", id);
                command.Parameters.AddWithValue("@password", password).SqlDbType = SqlDbType.VarChar;
                return DataBase.ExecuteBasicCommand(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
