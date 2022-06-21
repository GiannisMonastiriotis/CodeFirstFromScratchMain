using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstFromScratchMain.Models
{
    public class Category
    {
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        [Display(Name = "Category")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}