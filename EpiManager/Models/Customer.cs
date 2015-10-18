using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        
        [StringLength(50)]
        [DisplayName("მობილური")]
        public string MobileNumber { get; set; }

        //[Display(Name = "Full Name")]
        [Required]
        [MaxLength(100)]
        [DisplayName("სახელი, გვარი")]
        public string FullName { get; set; }

        [StringLength(1), Column(TypeName = "char")]
        [DisplayName("სქესი")]
        public string Gender { get; set; }

        [StringLength(400)]
        [DisplayName("კომენტარი")]
        public string Note { get; set; }

        [Required]
        [DisplayName("ფასის პაკეტი")]
        public int PriceHeaderId { get; set; }
        public virtual PriceHeader PriceHeader { get; set; }

        public DateTime? PriceExpiryDate { get; set; }
    }
}