using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Users
{
    public class CreateUserDto
    {
        [Required] public string Role { get; set; } = null!;
        [Required, MaxLength(50)] public string FirstName { get; set; } = null!;
        [Required, MaxLength(50)] public string LastName { get; set; } = null!;
        [Required, EmailAddress] public string Email { get; set; } = null!;
        [Required, MinLength(6)] public string Password { get; set; } = null!;
        public object? Addresses { get; set; }
        public object? SupplierDetails { get; set; }
        public object? BuyerDetails { get; set; }
        public object? DeliveryPartnerDetails { get; set; }
    }
}