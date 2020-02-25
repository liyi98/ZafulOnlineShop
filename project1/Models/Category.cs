using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
