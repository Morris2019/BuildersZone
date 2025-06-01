using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Products
{
     public class ProductImageDto
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPrimary { get; set; }
        public string AltText { get; set; }
        public DateTime UploadedAt { get; set; }
        public object Metadata { get; set; }
    }
}