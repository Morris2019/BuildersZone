using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Transactions
{
    public class TransactionDto
    {
        public string Id { get; set; }
        public string OrderId { get; set; }
        public string PaymentMethodId { get; set; }
        public string PaymentGatewayId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public object FraudCheck { get; set; }
        public DateTime CreatedAt { get; set; }
    }
   
}