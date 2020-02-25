using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class Product
    {
     
        public int ProductId { get; set; }
        [MaxLength(64)]
        [Required]
        public string ProductName {get;set;}

        [Column(TypeName = "decimal(10, 2)")]
        [Required]
        public double Price { get; set; }
        [Required]
        public string ImagePath { get; set; }
        [Required]
        public int Stock { get; set; }
        public string Size { get; set; }
        public DateTime CreationDate { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }


        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [NotMapped]
        public Category category { get; set; }
        public Product() { }
        public Product(int _ProductId, string _ProductName, Double _Price, string _ImagePath, int _Stock, string _Size, int _CategoryId)
        {
            ProductId = _ProductId;
            ProductName = _ProductName;
            Price = _Price;
            ImagePath = _ImagePath;
            Stock = _Stock;
            Size = _Size;
            CreationDate = DateTime.Now;
            CategoryId = _CategoryId;
        }
    }
}
