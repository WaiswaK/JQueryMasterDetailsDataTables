using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JQueryDataTables.Models;

namespace JQueryDataTables.Models
{
    public class DataRepository
    {

        /// <summary>
        /// Singleton collection of companies
        /// </summary>
        public static IList<Company> CompanyData = null;

        /// <summary>
        /// Method that returns all companies used in this example
        /// </summary>
        /// <returns>List of companies</returns>
        public static IList<Company> GetCompanies()
        {
            if (CompanyData == null)
            {
                CompanyData = new List<Company>();
                CompanyData.Add(new Company() { Name = "Emkay Entertainments", Address = "Nobel House, Regent Centre", Town = "Lothian" });
                CompanyData.Add(new Company() { Name = "The Empire", Address = "Milton Keynes Leisure Plaza", Town = "Buckinghamshire" });
                CompanyData.Add(new Company() { Name = "Asadul Ltd", Address = "Hophouse", Town = "Essex" });
                CompanyData.Add(new Company() { Name = "Gargamel ltd", Address = "", Town = "" });
                CompanyData.Add(new Company() { Name = "Ashley Mark Publishing Company", Address = "1-2 Vance Court", Town = "Tyne & Wear" });
                CompanyData.Add(new Company() { Name = "MuchMoreMusic Studios", Address = "Unit 29", Town = "London" });
                CompanyData.Add(new Company() { Name = "Victoria Music Ltd", Address = "Unit 215", Town = "London" });
                CompanyData.Add(new Company() { Name = "Abacus Agent", Address = "Regent Street", Town = "London" });
                CompanyData.Add(new Company() { Name = "Atomic", Address = "133 Longacre", Town = "London" });
                CompanyData.Add(new Company() { Name = "Pyramid Posters", Address = "The Works", Town = "Leicester" });
                CompanyData.Add(new Company() { Name = "Kingston Smith Financial Services Ltd", Address = "105 St Peter's Street", Town = "Herts" });
                CompanyData.Add(new Company() { Name = "Garrett Axford PR", Address = "Harbour House", Town = "West Sussex" });
                CompanyData.Add(new Company() { Name = "Derek Boulton Management", Address = "76 Carlisle Mansions", Town = "London" });
                CompanyData.Add(new Company() { Name = "Total Concept Management (TCM)", Address = "PO Box 128", Town = "West Yorks" });
                CompanyData.Add(new Company() { Name = "Billy Russell Management", Address = "Binny Estate", Town = "Edinburgh" });
                CompanyData.Add(new Company() { Name = "Stage Audio Services", Address = "Unit 2", Town = "Stourbridge" });
                CompanyData.Add(new Company() { Name = "Windsong International", Address = "Heather Court", Town = "Kent" });
                CompanyData.Add(new Company() { Name = "Vivante Music Ltd", Address = "32 The Netherlands", Town = "Surrey" });
                CompanyData.Add(new Company() { Name = "Way to Blue", Address = "First Floor", Town = "London" });
                CompanyData.Add(new Company() { Name = "Glasgow City Halls", Address = "32 Albion Street", Town = "Lanarkshire" });

            }

            return CompanyData;
        }
        public static IList<Employee> EmployeeData = null;
        public static IList<Employee> GetEmployees()
        {
            if (EmployeeData == null)
            {
                EmployeeData = new List<Employee>();
                EmployeeData.Add(new Employee() { EmployeeID = 19, Name = "Cathi Payne", Position = "Sales Representative", Phone="+358 23 4339340", Email="cathi@ibm.com", CompanyID = 1 });
                EmployeeData.Add(new Employee() { EmployeeID = 20, Name = "Maria Green", Position = "Vice President, Sales", Phone = "+358 33 74390", Email = "greeni@ibm.com", CompanyID = 0 });
                EmployeeData.Add(new Employee() { EmployeeID = 21, Name = "Mike Payne", Position = "Sales Representative", Phone = "+358 53 4330788", Email = "N/A", CompanyID = 2 });
                EmployeeData.Add(new Employee() { EmployeeID = 22, Name = "Jean Lawson", Position = "Sales Representative", Phone="+358 53 3435440", Email="cathi@yahoo.com", CompanyID = 3 });
                EmployeeData.Add(new Employee() { EmployeeID = 23, Name = "Brad Pitt", Position = "Sales Manager", Phone = "+328 23 553340", Email = "N/A", CompanyID = 3 });
                EmployeeData.Add(new Employee() { EmployeeID = 24, Name = "Jona Lomu", Position = "Sales Representative", Phone = "", Email = "cathi@google.com", CompanyID = 4 });
                EmployeeData.Add(new Employee() { EmployeeID = 25, Name = "Michael Jones", Position = "Sales Representative", Phone = "+358 23 4339340", Email = "N/A", CompanyID = 4 });
                EmployeeData.Add(new Employee() { EmployeeID = 26, Name = "Michele Pfeiffer", Position = "Inside Sales Coordinator", Phone = "+361 78 49345550", Email = "N/A", CompanyID = 5 });
                EmployeeData.Add(new Employee() { EmployeeID = 186, Name = "Darket, Michele", Position = "Principals Secretary", Phone = "+381 13 9344450", Email = "jack@gmail.com", CompanyID = 1 });
                EmployeeData.Add(new Employee() { EmployeeID = 187, Name = "Davis, Constance", Position = "Cook/Baker", Phone = "+358 23 4339340", Email = "constancei@ibm.com", CompanyID = 2 });
                EmployeeData.Add(new Employee() { EmployeeID = 188, Name = "Davis, Eric", Position = "Economics", Phone = "", Email = "N/A", CompanyID = 3 });
                EmployeeData.Add(new Employee() { EmployeeID = 189, Name = "Davis, Lori", Position = "5th Grade", Phone = "+358 23 4339340", Email = "lory@ibm.com", CompanyID = 4 });
                EmployeeData.Add(new Employee() { EmployeeID = 190, Name = "Day, Alyssa", Position = "Kindergarten", Phone = "", Email = "N/A", CompanyID = 0 });
                EmployeeData.Add(new Employee() { EmployeeID = 191, Name = "Deakins, Jeanette", Position = "Admin. Assistant", Phone = "+358 23 4339340", Email = "jess@ibm.com", CompanyID = 1 });
                EmployeeData.Add(new Employee() { EmployeeID = 192, Name = "DeGroat, Jessica", Position = "5th Grade", Phone = "+377 98 93404544", Email = "N/A", CompanyID = 2 });
                EmployeeData.Add(new Employee() { EmployeeID = 193, Name = "DelVecchio, Lindsay", Position = "3rd Grade", Phone = "+358 13 5934033", Email = "N/A", CompanyID = 3 });
                EmployeeData.Add(new Employee() { EmployeeID = 194, Name = "DelVecchio, Lisa", Position = "Assistant Principal", Phone = "+318 63 4339340", Email = "lisa@google.com", CompanyID = 4 });
                
            }
            return EmployeeData;
        }
    }
}