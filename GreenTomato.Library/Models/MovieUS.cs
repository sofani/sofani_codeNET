using System.Collections.Generic;
using System.Xml.Serialization;
using GreenTomato.Library.Interfaces;
using System;
namespace GreenTomato.Library.Models
{
    public class MovieUS : IMovie
    {
        [XmlIgnore]
        public string Title { get; set; }
        [XmlElement("catagory")]
        public Gener Gener { get; set; }
        public List<Actor> Actors { get; set; }


        public MovieUS() {
            Title = "sofani";
            Gener = new Gener();
            Actors  = new List<Actor>() {
                new Actor()
            };
        }
        public override string ToString() {
            return "$^{Title} {Gener} {Actors[0]}";
        }
        public void dispose() {
            GC.Collect();
        }

        ~MovieUS() {

        }
    }
}
