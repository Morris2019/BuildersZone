using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Products
{
    public class CreateProductDto
    {
        [Required]
        public string ShopId { get; set; }

        [Required]
        public string CategoryId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Color { get; set; }
        public object Sizes { get; set; }
        public object DynamicAttributes { get; set; }
    }
}