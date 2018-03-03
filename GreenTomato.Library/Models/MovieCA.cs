using System.Collections.Generic;
using GreenTomato.Library.Interfaces;

namespace GreenTomato.Library.Models
{
    public class MovieCA: IMovie
    {
        public string Title { get; set; }
        public Gener Gener { get; set; }
        public List<Actor> Actors { get; set; }
    }
}