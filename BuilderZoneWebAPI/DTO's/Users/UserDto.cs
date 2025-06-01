using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Users
{
    public class UserDto
    {
       public string Id { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public bool IsEmailVerified { get; set; }
        public bool IsActive { get; set; }
        public object Addresses { get; set; } = null!;
        public object SupplierDetails { get; set; } = null!;
        public object BuyerDetails { get; set; } = null!;
        public object DeliveryPartnerDetails { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
    }
}