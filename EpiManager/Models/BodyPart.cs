using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class BodyPart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BodyPartId { get; set; }
        [StringLength(100)]
        public string BodyPartName { get; set; }
        [StringLength(100)]
        public string BodyPartDescrip { get; set; }

        [StringLength(1), Column(TypeName = "char")]
        public string Gender { get; set; }
        public int ProcedureDurationInMinutes { get; set; }

        public int MigrId { get; set; }
    }
}