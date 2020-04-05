using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DisplayName("Product Price")]
        public int Price { get; set; }
        [DisplayName("Product Image")]
        public string Image { get; set; }
        [DisplayName("Product Description")]
        public string Description { get; set; }
        [DisplayName("Product Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    }
}