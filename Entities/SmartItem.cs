using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ShoppingSmart.Services.ItemsCatalog.Entities
{
    [Table("SmartItem")]
    public class SmartItem
    {
        [Key]
        public Guid Id { get; set; }


        [Required] 
        public string Name { get; set; }


        [Required] 
        public string Description { get; set; }


        [Required] 
        public string BrandName { get; set; }


        [Required]
        [Column(name: "Price", TypeName = "decimal")]
        public decimal Price { get; set; }



    }
}
