using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
         
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("თარიღი")]
        public DateTime? Date { get; set; }

        [DisplayName("კლიენტი")]
        public int CustomerId { get; set; }

        [DisplayName("ფასის კატეგორია")]
        public int PriceHeaderId { get; set; }

        public bool? CustomerNeverCame { get; set; }
        public string ImpulsesUsed { get; set; }




        public virtual PriceHeader PriceHeader { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<AppointmentTarget> AppointmentTargets { get; set; }


        #region Mapping Properties

        [DisplayName("ზონები")]
        public List<int> BodyParts { get; set; }

        #endregion

    }
}