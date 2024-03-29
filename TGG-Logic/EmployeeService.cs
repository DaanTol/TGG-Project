﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_DAL;
using TGG_Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TGG_Logic
{
    public class EmployeeService
    {
        private EmployeeDAO employeeDAO;
        private TGGEncryption encryptionService;

        public EmployeeService()
        {
            employeeDAO = new EmployeeDAO();
            encryptionService = new TGGEncryption();
        }

        //add employee
        public Employee AddEmployee(Employee employee)
        {
            return this.AddEmployee(new List<Employee> { employee }).First();
        }

        //add employees
        public List<Employee> AddEmployee(List<Employee> employees)
        {
            employees.ForEach(x => x.Password = encryptionService.HashWithSalt(x.Password));
            return employeeDAO.AddEmployee(employees);
        }

        //get all employees
        public List<Employee> GetAllEmployees()
        {
            return employeeDAO.GetAllEmployees();
        }

        //get employees by element
        public List<Employee> GetEmployeesByElement(BsonElement filterElement, params BsonElement[] extraFilterElement)
        {
            return employeeDAO.GetEmployeesByElement(filterElement, extraFilterElement);
        }

        //update employees by element
        public List<UpdateResult> UpdateEmployeeByElement(BsonElement filterElement, BsonElement updateElement, params BsonElement[] extraUpdateElements)
        {
            return employeeDAO.UpdateEmployeeByElement(filterElement, updateElement, extraUpdateElements);
        }

        //delete employees by element
        public DeleteResult DeleteEmployeeByElement(BsonElement filterElement)
        {
            return employeeDAO.DeleteEmployeeByElement(filterElement);
        }
    }
}
