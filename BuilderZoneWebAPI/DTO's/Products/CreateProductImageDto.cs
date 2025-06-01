using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Products
{
    public class CreateProductImageDto
    {
        [Required]
        public string ProductId { get; set; }

        [Required, Url]
        public string ImageUrl { get; set; }

        public bool IsPrimary { get; set; } = false;
        public string AltText { get; set; }
        public object Metadata { get; set; }
    }
}