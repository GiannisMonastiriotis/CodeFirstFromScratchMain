using CodeFirstFromScratchMain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstFromScratchMain.ViewModels
{
    public class ProductFormViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public Product  Product { get; set; }
    }
}