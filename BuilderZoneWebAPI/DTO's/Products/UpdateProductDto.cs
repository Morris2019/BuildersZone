using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Products
{
    public class UpdateProductDto
    {
        public string ShopId { get; set; } = null!;
        public string? CategoryId { get; set; } 
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string Color { get; set; } = null!;
        public object Sizes { get; set; } = null!;
        public object DynamicAttributes { get; set; } = null!;
        public bool? IsActive { get; set; }
    }
}