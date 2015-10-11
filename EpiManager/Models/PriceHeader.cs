using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class PriceHeader
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PriceHeaderId { get; set; }
        [StringLength(100)]
        public string PriceName { get; set; }
        [StringLength(100)]
        public string PriceDescrip { get; set; }

        public virtual ICollection<PriceLine> PriceLines { get; set; }
    }
}