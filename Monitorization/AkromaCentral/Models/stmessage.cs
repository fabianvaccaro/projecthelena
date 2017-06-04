using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkromaCentral.Models
{
    public class stmessage
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public bool incoming { get; set; }

        [Required]
        public DateTime date { get; set; }

        [Required]
        public string message { get; set; }
    }
}