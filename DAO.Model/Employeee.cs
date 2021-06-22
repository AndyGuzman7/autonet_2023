using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAO.Model
{
    public class Employeee : BaseModel
    {
        #region Properties
        public byte IdEmployee { get; set; }
        public string NameUser { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime  BirthDate { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Ci { get; set; }


        #endregion

        #region constructor
        public Employeee()
        {

        }
        /// <summary>
        /// select
        /// </summary>
        /// <param name="idEmployee"></param>
        /// <param name="nameUser"></param>
        /// <param name="password"></param>
        /// <param name="idUserType"></param>
        /// <param name="idEmployeeAdd"></param>

        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="gender"></param>
        public Employeee(byte idEmployee, string nameUser, string password, string userType, string firstName, string lastName, DateTime birthDate, string address, int phone, string gender, string email, byte status, DateTime registrationDate, DateTime dateUpdate, short idEmployeeAdd, string ci)
            : base(status, registrationDate, dateUpdate, idEmployeeAdd)
        {
            IdEmployee = idEmployee;
            NameUser = nameUser;
            Password = password;
            UserType = userType;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Address = address;
            Phone = phone;
            Gender = gender;
            Email = email;
            Ci = ci;
        }
        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="nameUser"></param>
        /// <param name="password"></param>
        /// <param name="idUserType"></param>
        /// <param name="idEmployeeAdd"></param>
        /// <param name="names"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="birthDate"></param>
        /// <param name="address"></param>
        /// <param name="phone"></param>
        /// <param name="gender"></param>

        public Employeee(string nameUser, string password, string userType, string firstName, string lastName, DateTime birthDate, string address, int phone, string gender, string email, string ci)
        {
            NameUser = nameUser;
            Password = password;
            UserType = userType;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Address = address;
            Phone = phone;
            Gender = gender;
            Email = email;
            Ci = ci;
        }




        #endregion

    }
}