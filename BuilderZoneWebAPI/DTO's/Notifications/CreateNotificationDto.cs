using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Notifications
{
    public class CreateNotificationDto
    {
        [Required] public string UserId { get; set; } = null!;
        [Required] public string Type { get; set; } = null!;
        [Required] public string Message { get; set; } = null!;
    }
}