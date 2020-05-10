using Microsoft.EntityFrameworkCore.Internal;
using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {

        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        // Seeder: Will fill my DB with data
        public void Seed()
        {
            // Check if theres any data on my DB (already filled)
            if (_context.Department.Any()
                || _context.Sale.Any()
                || _context.Seller.Any()){
                return;
            }


            //Departments
            Department d1 = new Department { Name = "Computers" };
            Department d2 = new Department { Name = "Electronics" };
            Department d3 = new Department { Name = "Fashion" };
            Department d4 = new Department { Name = "Books" };

            _context.Department.AddRange(d1, d2, d3, d4);


            //Sellers
            Seller s1 = new Seller
            {
                Name = "Bob Brown",
                Email = "bob@gmail.com",
                BirthDate = new DateTime(1998, 4, 21),
                BaseSalary = 1000.0,
                Department = d1
            };
            Seller s2 = new Seller
            {
                Name = "Maria Green",
                Email = "mariagreen@gmail.com",
                BirthDate = new DateTime(1979, 12, 31),
                BaseSalary = 1050.0,
                Department = d1
            };
            Seller s3 = new Seller
            {
                Name = "Alex Gray",
                Email = "alexgray@gmail.com",
                BirthDate = new DateTime(1988, 1, 15),
                BaseSalary = 970.0,
                Department = d1
            };
            Seller s4 = new Seller
            {
                Name = "Martha Red",
                Email = "marthared@gmail.com",
                BirthDate = new DateTime(1993, 11, 30),
                BaseSalary = 890.0,
                Department = d1
            };
            Seller s5 = new Seller
            {
                Name = "Donald Blue",
                Email = "donaldblue@gmail.com",
                BirthDate = new DateTime(2000, 1, 9),
                BaseSalary = 870.0,
                Department = d1
            };
            Seller s6 = new Seller
            {
                Name = "Jaina Pink",
                Email = "jainapink@gmail.com",
                BirthDate = new DateTime(1997, 3, 4),
                BaseSalary = 1110.0,
                Department = d1
            };

            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);


            //Sales
            Sale sa1 = new Sale { Seller = s1, Date = new DateTime(2018, 9, 13), Status = SaleStatus.Billed, Amount = 1254.0 };
            Sale sa2 = new Sale { Seller = s2, Date = new DateTime(2018, 10, 13), Status = SaleStatus.Canceled, Amount = 8446.0 };
            Sale sa3 = new Sale { Seller = s3, Date = new DateTime(2018, 8, 25), Status = SaleStatus.Pending, Amount = 1214.0 };
            Sale sa4 = new Sale { Seller = s4, Date = new DateTime(2018, 1, 8), Status = SaleStatus.Billed, Amount = 250.0 };
            Sale sa5 = new Sale { Seller = s5, Date = new DateTime(2019, 5, 2), Status = SaleStatus.Pending, Amount = 167.0 };
            Sale sa6 = new Sale { Seller = s1, Date = new DateTime(2017, 6, 16), Status = SaleStatus.Billed, Amount = 5248.0 };
            Sale sa7 = new Sale { Seller = s5, Date = new DateTime(2018, 5, 20), Status = SaleStatus.Canceled, Amount = 535.0 };
            Sale sa8 = new Sale { Seller = s2, Date = new DateTime(2018, 12, 03), Status = SaleStatus.Billed, Amount = 1643.0 };

            _context.Sale.AddRange(sa1, sa2, sa3, sa4, sa5, sa6, sa7, sa8);

            _context.SaveChanges();

        }

    }
}
