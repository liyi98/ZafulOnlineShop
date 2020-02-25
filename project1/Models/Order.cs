using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime CreationDate { get; set; }
        [Required]
        public string Status { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        [NotMapped]
        public List<CartProduct> cartProducts{  get; set; }
    }
}
