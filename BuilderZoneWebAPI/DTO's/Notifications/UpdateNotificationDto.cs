using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Notifications
{
    public class UpdateNotificationDto
    {
        public string? Type { get; set; }
        public string? Message { get; set; }
        public bool? IsRead { get; set; }
    }
}