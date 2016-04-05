using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LocalStorage.Models
{
    public class Step2
    {

        [StringLength(50)]
        public string Address1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Address2 { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [StringLength(5)]
        [DataType(DataType.PostalCode)]
        public string Zip { get; set; }
    }
}