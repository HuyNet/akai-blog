﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.Domian.Identity
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>
    {
        [Required]
        [MaxLength(100)]
        public required string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public required string LastName { get; set; }
        public bool IsActived { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public DateTime? Dob {  get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime? VipStartDate { get; set; }
        public DateTime? VipEndDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public decimal? Balance { get; set; }
        public string? Avatar {  get; set; }

    }
}
