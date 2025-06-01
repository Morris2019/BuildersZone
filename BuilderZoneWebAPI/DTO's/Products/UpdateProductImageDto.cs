using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Products
{
    public class UpdateProductImageDto
    {
        public string ImageUrl { get; set; }
        public bool? IsPrimary { get; set; }
        public string AltText { get; set; }
        public object Metadata { get; set; }
    }
}