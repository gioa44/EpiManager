using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }

        //[StringLength(9, MinimumLength = 9)]
        [Required]
        [StringLength(50)]
        public string MobileNumber { get; set; }

        //[Display(Name = "Full Name")]
        [Required]
        [MaxLength(100)]
        public string FullName { get; set; }

        [StringLength(1), Column(TypeName = "char")]
        public string Gender { get; set; }

        [StringLength(400)]
        public string Note { get; set; }

        [Required]
        public int PriceHeaderId { get; set; }
        public virtual PriceHeader PriceHeader { get; set; }

        public DateTime? PriceExpiryDate { get; set; }
    }
}