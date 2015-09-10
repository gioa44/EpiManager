using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class BodyPart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BodyPartId { get; set; }
        public string BodyPartName { get; set; }
        public string BodyPartDescrip { get; set; }
    }
}