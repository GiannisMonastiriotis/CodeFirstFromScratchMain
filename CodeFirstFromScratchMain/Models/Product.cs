using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstFromScratchMain.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enger a Product Name")]
        [StringLength(244)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        public string Description { get; set; }

        [Display(Name = "Category")]
        public Category Category { get; set; }

        public int CaregoryId { get; set; }
    }
}