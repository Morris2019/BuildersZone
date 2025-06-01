using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Discounts
{
     public class CreateDiscountDto
    {
        [Required]
        public string ProductId { get; set; }

        [Required]
        public string Type { get; set; }

        public int MinQuantity { get; set; }
        public string CouponCode { get; set; }

        [Range(0, 100)]
        public decimal DiscountPercentage { get; set; }

        [Required]
        public DateTime ExpiresAt { get; set; }
    }
}