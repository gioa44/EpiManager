using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class PriceLine
    {
        public int PriceHeaderId { get; set; }
        public int PriceLineId { get; set; }
        public int EpiKindId { get; set; }
        public decimal Price { get; set; }

        public virtual PriceHeader PriceHeader { get; set; }
    }
}