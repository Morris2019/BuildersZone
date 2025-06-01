using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.ActivityLogs
{
    public class UserActivityDto
    {
         public string Id { get; set; }
        public string UserId { get; set; }
        public string Action { get; set; }
        public string Query { get; set; }
        public string ProductId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
