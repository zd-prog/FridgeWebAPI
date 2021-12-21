using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class FridgeProducts
    {
        [Column("FridgeProductId")]
        public Guid Id { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required]
        public Guid FridgeId { get; set; }
        public Product Product { get; set; }
        public Fridge Fridge { get; set; }
        [Required(ErrorMessage ="Quantity is a required field")]
        public int Quantity { get; set; }
    }
}
