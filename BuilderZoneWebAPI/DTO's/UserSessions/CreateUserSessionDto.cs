using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.UserSessionDtos
{
    public class CreateUserSessionDto
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string JwtId { get; set; }

        [Required]
        public string RefreshTokenHash { get; set; }

        public string UserAgent { get; set; }
        public string IpAddress { get; set; }

        [Required]
        public DateTime ExpiresAt { get; set; }
    }
}