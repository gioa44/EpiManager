using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class AppointmentTarget
    {
        [Column(Order = 0), Key]
        public int AppointmentId { get; set; }
        [Column(Order = 1), Key]
        public int BodyPartId { get; set; }
        [StringLength(100)]
        public string ImpulsesUsed { get; set; }

        //public decimal IntendPrice { get; set; }
        //public decimal ActualPrice { get; set; }

        public virtual BodyPart BodyPart { get; set; }

        public virtual Appointment Appointment { get; set; }
    }
}