using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.PaymentMethods
{ 
     public class PaymentMethodDto
    {
         public string Id { get; set; }
        public string UserId { get; set; }
        public string Type { get; set; }
        public string Provider { get; set; }
        public string MaskedDetails { get; set; }  // Changed from Details
        public bool IsDefault { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}