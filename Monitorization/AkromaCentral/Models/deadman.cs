using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkromaCentral.Models
{
    public class deadman
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public DateTime date { get; set; }
    }
}