using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Inventory
{
    public class UpdateInventoryDto
    {
       public int? Stock { get; set; }
        public object Location { get; set; }
    }
}