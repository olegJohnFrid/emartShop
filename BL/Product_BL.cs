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
    public class Product_BL
    {
        public Product_Data itsDAL;

        public Product_BL(Product_Data dl)
        {
            itsDAL = dl;
        }

        //adds new product to database
        public string Add(string name, string type, string departmentID, string stockCount, string price)
        {
            if(existByName(name))
            {
                itsDAL.Restock(this.getProductsInStockByName(name).name, stockCount);
                return "";
            }
            string id = generateID();
            bool inStock = false;
            if (int.Parse(stockCount) > 0)
            {
                inStock = true;
            }
            Backend.Product temp = new Backend.Product(name, (Backend.Product.Type)Enum.Parse(typeof(Backend.Product.Type), type), id, departmentID, inStock, int.Parse(stockCount), double.Parse(price));

            itsDAL.Add(temp);
            return id;
        }

        //id generator
        private static string generateID()
        {
            DateTime date = DateTime.Now;
            string uniqueID = String.Format("{0:0000}{1:00}{2:00}{3:00}{4:00}{5:00}", date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
            return uniqueID;
        }

        public bool exist(string productId)
        {
            return itsDAL.Contains(productId);
        }

        public bool existByName(string name)
        {
            foreach (Backend.Product p in itsDAL.DB)
            {
                if (p.name == name) return true;
            }
            return false;
        }

        //removes product from database
        public Boolean Remove(string productId)
        {
            if (exist(productId))
            {
                itsDAL.Remove(productId);
                return true;
            }
            return false;
        }

        /*
         * query functions for poduct database
         */
        public string getAllProducts()
        {
            return itsDAL.getAllProducts();
        }

        public List<Backend.Product> getAllProductsList()
        {
            return itsDAL.getAllProductsList();
        }

        public List<Backend.Product> getAllProductsListByDepartmentID(String ID)
        {
            List<Backend.Product> ans = new List<Backend.Product>();
            List<Backend.Product> list = itsDAL.getAllProductsList();
            foreach (Backend.Product p in list)
            {
                if (p.departmentID == ID)
                {
                    ans.Add(p);
                }
            }
            return ans;
        }

        public List<Backend.Product> getProductsListByType(Backend.Product.Type type)
        {
            List<Backend.Product> list = itsDAL.getAllProductsList();
            List<Backend.Product> ans = new List<Backend.Product>();
            foreach (Backend.Product p in list)
            {
                if (p.type == type)
                    ans.Add(p);
            }
            return ans;
        }

        public string Restock(string inventoryId, string addition)
        {
            return itsDAL.Restock(inventoryId, addition);
        }

        public Backend.Product getProductsInStockByName(string name)
        {
            return itsDAL.getProductsInStockByName(name);
        }

        public Backend.Product getProductsInStockByID(string id)
        {
            List<Backend.Product> list = itsDAL.getAllProductsList();
            Backend.Product ans = new Backend.Product();
            foreach (Backend.Product p in list)
            {
                if (p.inventoryID == id)
                    ans = p;
            }
            return ans;
        }

        public string getProductsInStockByDepartment(string name)
        {
            return itsDAL.getProductsInStockByDepartment(name);
        }

        public string getProductsInStockByPriceRange(string min, string max)
        {
            return itsDAL.getProductsInStockByPriceRange(min, max);
        }

        public bool updateProduct(string id, string name, string type, string departmentId, string price,String stockCount)
        {
            return itsDAL.updateProduct(id, name, (Backend.Product.Type)Enum.Parse(typeof(Backend.Product.Type), type), departmentId, double.Parse(price), int.Parse(stockCount));
        }
       

        public void RemoveDepartment(string id)
        {
            itsDAL.RemoveDepartment(id);
        }

        public string getPriceByProductID(string id)
        {
            return itsDAL.getPriceByProductID(id);
        }



        public List<Backend.Product> getAllProductsListInStock()
        {
            return itsDAL.getAllProductsListInStock();
        }

        public List<Backend.Product> getProductsListByTypeInStock(Backend.Product.Type type)
        {
            List<Backend.Product> list = itsDAL.getAllProductsList();
            List<Backend.Product> ans = new List<Backend.Product>();
            foreach (Backend.Product p in list)
            {
                if (p.type == type && p.inStock)
                    ans.Add(p);
            }
            return ans;
        }
    }
}
