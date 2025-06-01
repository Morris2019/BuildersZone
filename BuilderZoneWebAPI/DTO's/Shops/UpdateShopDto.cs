using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Shops
{
   public class UpdateShopDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public object Address { get; set; }
        public object ContactInfo { get; set; }
        public bool? IsActive { get; set; }
    } 
}