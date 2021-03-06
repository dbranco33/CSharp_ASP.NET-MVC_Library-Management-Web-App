﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryMgmtApp.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        [Required(ErrorMessage = "This field is mandatory")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Type of Membership")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }
    }
}