using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Products
{
     public class ProductDto
    {
        public string Id { get; set; }
        public string ShopId { get; set; }
        public string CategoryId { get; set; }
        [Required]public string Name { get; set; } = null!;
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public object Sizes { get; set; }
        public object DynamicAttributes { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}