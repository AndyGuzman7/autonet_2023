﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Model
{
    public class Spare : BaseModel
    {

        #region Properties

        public int IdSpare { get; set; }
        public string Description { get; set; }
        public string NameProduct { get; set; }
        public int CurrentBalance { get; set; }
        public double BasePrice { get; set; }
        public double Weight { get; set; }
        public string ProductCode { get; set; }
        public int IdFactory { get; set; }
        public int IdSpareType { get; set; }

        #endregion

        #region Constructors
        public Spare()
        {

        }

        /// <summary>
        /// Select
        /// </summary>
        /// <param name="idSpare"></param>
        /// <param name="description"></param>
        /// <param name="nameProduct"></param>
        /// <param name="currentBalance"></param>
        /// <param name="basePrice"></param>
        /// <param name="weight"></param>
        /// <param name="productCode"></param>
        /// <param name="idFactory"></param>
        /// <param name="idSpareType"></param>
        /// <param name="status"></param>
        /// <param name="registrationDate"></param>
        /// <param name="dateUpdate"></param>
        /// <param name="idEmploye"></param>
        public Spare(int idSpare, string description, string nameProduct, int currentBalance, double basePrice, double weight, string productCode, int idFactory, int idSpareType, byte status, DateTime registrationDate, DateTime dateUpdate, short idEmploye)
                     :base(status, registrationDate, dateUpdate, idEmploye)
        {
            IdSpare = idSpare;
            Description = description;
            NameProduct = nameProduct;
            CurrentBalance = currentBalance;
            BasePrice = basePrice;
            Weight = weight;
            ProductCode = productCode;
            IdFactory = idFactory;
            IdSpareType = idSpareType;
        }

        /// <summary>
        /// Insert
        /// </summary>
        /// <param name="description"></param>
        /// <param name="nameProduct"></param>
        /// <param name="currentBalance"></param>
        /// <param name="basePrice"></param>
        /// <param name="weight"></param>
        /// <param name="productCode"></param>
        /// <param name="idFactory"></param>
        /// <param name="idSpareType"></param>
        /// <param name="idEmploye"></param>
        public Spare(string description, string nameProduct, int currentBalance, double basePrice, double weight, string productCode, int idFactory, int idSpareType, short idEmploye)
        {
            Description = description;
            NameProduct = nameProduct;
            CurrentBalance = currentBalance;
            BasePrice = basePrice;
            Weight = weight;
            ProductCode = productCode;
            IdFactory = idFactory;
            IdSpareType = idSpareType;
            IdEmploye = idEmploye;
        }




        #endregion
    }
}