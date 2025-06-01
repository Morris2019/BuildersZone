using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.UsersProfileImages
{
    public class CreateUserProfileImageDto
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        [Url]
        public string ImageUrl { get; set; }

        public bool IsPrimary { get; set; } = false;
        public string ImageType { get; set; }
        public object Metadata { get; set; }
    }
}