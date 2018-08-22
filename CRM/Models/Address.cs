using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Town { get; set; }

        [Required]
        [StringLength(15)]
        [DisplayName("Post Code")]
        public string PostCode { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Street Name")]
        public string StreetName { get; set; }

        [Required]
        [StringLength(255)]
        [DisplayName("Street Number")]
        public string StreetNumber { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [DisplayName("Town")]
        public string CorrespondenceTown { get; set; }
        [DisplayName("Post Code")]
        public string CorrespondencePostCode { get; set; }
        [DisplayName("Street Name")]
        public string CorrespondenceStreetName { get; set; }
        [DisplayName("Street Number")]
        public string CorrespondenceStreetNumber { get; set; }
        [DisplayName("Description")]
        public string CorrespondenceDescription { get; set; }

    }
}