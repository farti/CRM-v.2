using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CRM.Models
{
    public class Gender
    {
        public byte Id { get; set; }

        [DisplayName("Title")]
        public string GenderType { get; set; }
    }
}