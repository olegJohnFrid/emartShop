﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend;
using DAL;

namespace BL
{
    [Serializable]
    public class Transaction_BL
    {
        public Transaction_Data itsDAL;

        public Transaction_BL(Transaction_Data dl)
        {
            itsDAL = dl;
        }

        //checks if transaction exsist in database
        public bool exist(string id)
        {
            return itsDAL.Contains(id);
        }

        //id generator
        private static string generateID()
        {
            DateTime date = DateTime.Now;
            string uniqueID = String.Format("{0:0000}{1:00}{2:00}{3:00}{4:00}{5:00}", date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
            return uniqueID;
        }

        public void Add(bool isAReturn, string receipt, string paymentMethod, string id)
        {
            itsDAL.Add(generateID(), DateTime.Now, isAReturn, receipt, paymentMethod, id);
        }

        public void Remove(string id)
        {
            itsDAL.Remove(id);
        }

        /*
         * query functions for transaction database
         */
        public bool isAReaturn(string id)
        {
            return itsDAL.isAReaturn(id);
        }

        public string getPaymentMethod(string id)
        {
            return itsDAL.getPaymentMethod(id);
        }

        public string getReceiptByTransactionID(string id)
        {
            return itsDAL.getReceiptByTransactionID(id);
        }

        public string getAllTransactions()
        {
            return itsDAL.getAllTransactions();
        }
        public List<Backend.Transaction> getAllTransactionsList()
        {
            return itsDAL.DB;
        }

        public bool updateTransaction(string transactionID, string dateTime, bool isAReturn, string paymentMethod)
        {
            return itsDAL.updateTransaction(transactionID, Convert.ToDateTime(dateTime), isAReturn, paymentMethod);
        }

        public List<Backend.Transaction> getTransactionByMonth(int p)
        {
            var transaction =
              from t in itsDAL.DB
              where t.dateTime.Month == p
              select t;
            List<Backend.Transaction> list = new List<Backend.Transaction>();
            foreach (Backend.Transaction t in transaction)
            {
                list.Add(t);
            }
            return list;
        }

        public void addRecipt(Receipt r)
        {
            itsDAL.addRecipt(r);
        }

        public List<Receipt> getReciptList()
        {
            return itsDAL.receiptDB;
        }

        public List<Backend.Transaction> getTransactionsByCustomerID(String id)
        {
            return itsDAL.getTransactionsByCustomerID(id);
        }

        public List<Backend.Transaction> getTransactionsByID(String transID)
        {
            return itsDAL.getTransactionsByID(transID);
        }

    }
}
