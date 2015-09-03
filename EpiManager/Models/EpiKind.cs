using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EpiManager.Models
{
    public class EpiKind
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EpiKindId { get; set; }
        public string EpiKindName { get; set; }
        public string EpiKindDescrip { get; set; }
    }
}