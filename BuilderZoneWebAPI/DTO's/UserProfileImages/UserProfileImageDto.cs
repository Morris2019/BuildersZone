using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.UsersProfileImages
{
    public class UserProfileImageDto
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPrimary { get; set; }
        public string ImageType { get; set; }
        public DateTime UploadedAt { get; set; }
        public object Metadata { get; set; }
    }
}