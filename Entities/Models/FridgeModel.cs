using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class FridgeModel
    {
        [Column("FridgeModelId")]
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Fridge model name is a required field.")]
        [MaxLength(60, ErrorMessage ="Maximum length for the Fridge model name is 60 characters.")]
        public string Name { get; set; }
        [Range(1970, 2022)]
        public int Year { get; set; }
        public ICollection<Fridge> Fridges { get; set; }
    }
}
