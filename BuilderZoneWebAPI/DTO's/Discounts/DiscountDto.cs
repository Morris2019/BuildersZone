using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Discounts
{
    public class DiscountDto
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public string Type { get; set; }
        public int MinQuantity { get; set; }
        public string CouponCode { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}