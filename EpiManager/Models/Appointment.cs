using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public int PriceHeaderId { get; set; }
        public virtual PriceHeader PriceHeader { get; set; }
    }
}