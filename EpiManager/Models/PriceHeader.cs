using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class PriceHeader
    {
        public int PriceHeaderId { get; set; }
        public string PriceName { get; set; }

        public virtual ICollection<PriceLine> PriceLines { get; set; }
    }
}