using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.DeliveryPartners
{
   public class DeliveryPartnerDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public object DeliveryAreas { get; set; }
        public decimal CostPerKm { get; set; }
        public object ContactInfo { get; set; }
        public object CurrentLocation { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}