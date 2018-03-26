using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMvc.Models
{
    public class Session
    {
        public Int32 SessionId { get; set; }

        [Display(Name="Speaker")]
        public string Title { get; set; }

        [Required()]
        [DataType(DataType.MultilineText)]
        public string Abstract { get; set; }

        public Int32 SpeakerId { get; set; }
        public virtual Speaker Speaker { get; set; }
    }
}
