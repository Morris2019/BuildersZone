using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.DeliveryPartners
{
    public class CreateDeliveryPartnerDto
    {
        [Required]
        public string Name { get; set; }

        public object DeliveryAreas { get; set; }

        [Required]
        public decimal CostPerKm { get; set; }

        public object ContactInfo { get; set; }
        public object CurrentLocation { get; set; }
        public bool IsActive { get; set; } = true;
    }
}