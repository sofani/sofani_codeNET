 using GreenTomato.Library.Attributes;

namespace  GreenTomato.Library.Interfaces { 

    public abstract class APlayer : IPlayer {
        public Screens Screens {get; set;}
        public Power Power{get;set;}
        public Button Button{get;set;}

        protected APlayer() {
           Create();
        }

        public virtual Create() {

        }
         public string  Forward() {
            throw new System.NotImplementedException;
        }

           public string  Pause() {
            throw new System.NotImplementedException;
        }
    }
}