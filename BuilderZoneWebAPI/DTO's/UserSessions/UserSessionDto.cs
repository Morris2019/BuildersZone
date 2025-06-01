using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.UserSessionDtos
{
    public class UserSessionDto
    {
         public string Id { get; set; }
        public string UserId { get; set; }
        public string JwtId { get; set; }
        public string UserAgent { get; set; }
        public string IpAddress { get; set; }
        public bool IsRevoked { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}