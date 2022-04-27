using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace Northwind.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Please enter category name")]
        public string CategoryName { get; set; } = null!;
        [Required(ErrorMessage = "Please enter Description")]
        public string Description { get; set; }
        public string? Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }


    }

}
