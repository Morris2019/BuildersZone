using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.ActivityLogs
{
    public class UpdateUserActivityDto
    {
        public string Action { get; set; }
        public string Query { get; set; }
        public string ProductId { get; set; }
    }
}