using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.Owin.BuilderProperties;

namespace CRM.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Surname { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [StringLength(255)]
        public string Town { get; set; }

        public Address Address { get; set; }
        public int? AddressId { get; set; }

        public Gender Gender { get; set; }
        [DisplayName("Title")]
        public byte GenderId { get; set; }
    }
}