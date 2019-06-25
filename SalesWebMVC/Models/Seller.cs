using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        
        public int DepartmentId { get; set; }

        public ICollection<SalesRecord> Sales = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int iD, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            ID = iD;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime init, DateTime end)
        {
            return Sales.Where(s => s.Date >= init && s.Date <= end).Sum(p => p.Amount);
        }
    }
}