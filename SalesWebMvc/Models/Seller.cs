﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<Sale> Sales { get; set; } = new List<Sale>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSale(Sale salesRecord)
        {
            Sales.Add(salesRecord);
        }

        public void RemoveSale(Sale saleRecord)
        {
            Sales.Remove(saleRecord);
        }

        public double GetTotalSalesAmoutByPeriod(DateTime initialDate, DateTime finalDate)
        {
            return Sales.Where(sr => sr.Date >= initialDate && sr.Date <= finalDate).Sum(sr => sr.Amount);
        }
    }
}
