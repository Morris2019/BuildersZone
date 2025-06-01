using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Shops
{
    public class CreateShopDto
    {
        [Required]
        public string UserId { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }
        public object Address { get; set; }
        public object ContactInfo { get; set; }
    }
}