using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Users
{
    public class UpdateUserDto
    {
        public string? Role { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool? IsEmailVerified { get; set; }
        public bool? IsActive { get; set; }
        public object? Addresses { get; set; }
        public object? SupplierDetails { get; set; }
        public object? BuyerDetails { get; set; }
        public object? DeliveryPartnerDetails { get; set; }
    }
}
