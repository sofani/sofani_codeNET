using System.Collections.Generic;

namespace MusicStoreFramework.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        
        public virtual Album Album { get; set; }

        public string Contents { get; set; }
        public string ReviewerEmail { get; set; }

    }
}