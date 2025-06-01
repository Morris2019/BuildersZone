using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.ActivityLogs
{
    public class CreateUserActivityDto
    {
        [Required] public string UserId { get; set; }
        [Required] public string Action { get; set; }
        public string Query { get; set; }
        public string ProductId { get; set; }
    }
}