using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.PaymentMethods
{ 
    public class CreateTransactionDto
    {
        [Required]
        public string OrderId { get; set; }
        [Required]
        public string PaymentMethodId { get; set; }
        public string PaymentGatewayId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Currency { get; set; }
        public string Status { get; set; }
        public object FraudCheck { get; set; }
    }
}