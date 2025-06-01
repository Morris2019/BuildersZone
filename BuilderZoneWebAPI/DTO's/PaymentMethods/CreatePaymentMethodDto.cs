using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.PaymentMethods
{ 
    public class CreatePaymentMethodDto
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Provider { get; set; }
        public object Details { get; set; }
        public bool IsDefault { get; set; } = false;
    }
}