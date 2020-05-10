using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        [Key]
        public int Id{ get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double GetTotalSalesAmountByPeriod(DateTime initialDate, DateTime finalDate)
        {
            return Sellers.Sum(seller => seller.GetTotalSalesAmoutByPeriod(initialDate,finalDate));
        }
    }
}
