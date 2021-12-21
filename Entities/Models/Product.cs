using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Product
    {
        [Column("ProductId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Product name is a required field")]
        [MaxLength(60, ErrorMessage ="Maximum length for the Product name is 60 characters.")]
        public string Name { get; set; }
        public int DefaultQuantity { get; set; }
        public ICollection<Fridge> Fridges { get; set; }
    }
}
