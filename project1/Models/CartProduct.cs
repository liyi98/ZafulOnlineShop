using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class CartProduct
    {
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public int CartProductId { get; set; }
        [Required]
        public int Quantity { get; set; }

        [ForeignKey("ProductId")]
        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
