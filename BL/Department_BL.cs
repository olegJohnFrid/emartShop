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
    public class Department_BL
    {
        Department_Data itsDAL;

        public Department_BL(Department_Data dl)
        {
            itsDAL = dl;
            //itsDAL.DB.Clear();
        }

        //checks if the club member exsist
        public bool exist(string id)
        {
            return itsDAL.contains(id);
        }

        //checks if name of departmenet alreadey exist in the system
        public bool isNameTaken(string name)
        {
            return itsDAL.isNameTaken(name);
        }

        //id generator, based on datetime
        private static string generateID()
        {
            DateTime date = DateTime.Now;
            string uniqueID = String.Format("{0:0000}{1:00}{2:00}{3:00}{4:00}{5:00}", date.Year, date.Month, date.Day, date.Hour, date.Minute, date.Second);
            return uniqueID;
        }

        //adds a department
        public string Add(string name)
        {
            string id = generateID();
            Backend.Department temp = new Backend.Department(name, id);
            itsDAL.Add(temp);
            return id;
        }

        //removes a department
        public Boolean Remove(string id)
        {
            if (exist(id))
            {
                return itsDAL.Remove(id);
            }
            return false;
        }

        public void RemoveByName(string name)
        {
            if (isNameTaken(name))
            {
                itsDAL.RemoveByName(name);
            }
        }

        /*
         * query functions for department
         */
        public string getAllDepartmentsString()
        {
            return itsDAL.getAllDepartmentString();
        }

        public List<Backend.Department> getAllDepartments()
        {
            return itsDAL.getAllDepartment();
        }


        public string getDepartmentByName(string name)
        {
            return itsDAL.getDepartmentByName(name);
        }

        public string getDepartmentByID(string id)
        {
            return itsDAL.getDepartmentByID(id);
        }

    }
}
