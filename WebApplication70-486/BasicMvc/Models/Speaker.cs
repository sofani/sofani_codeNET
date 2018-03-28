using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BasicMvc.Models
{
    public class Speaker
    {
        public Int32 SpeakerId { get; set; }

        [Required(ErrorMessage ="{0} is required")]
        [Display(Name="speaker name")]
        public string Name { get; set; }

        public string EmailAddress { get; set; }
       // public virtual List<Session> Sessions { get; set; }
    }
}
