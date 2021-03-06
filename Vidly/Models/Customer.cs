﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id{ get; set; }
        [Required]
        [StringLength(255)]
        public string Name{ get; set; }
        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypes MembershipTypes { get; set; }
        [Display(Name = "Membership Types")]
        public byte MembershipTypeId  { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}