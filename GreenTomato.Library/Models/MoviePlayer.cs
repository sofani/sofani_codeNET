using GreenTomato.Library.Interfaces;

namespace GreenTomato.Library.Models
{

       /*Singlton Pattern

         
        */
    public  class MoviePlayer : IPlayer
    {
        private  IMovie m;

     


        public  MoviePlayer(IMovie movie)
        {
            m = movie;
            var pl = new TVPlayer();
        }

        public  string Forward()
        {
            return string.Format("{0} {1}", "forward", m.ToString());
        }

        public  string Pause()
        {
            return string.Format("{0} {1}", "pause", m.ToString());
        }

        public  string Play()
        {
            return string.Format("{0} {1}", "play", m.ToString());
        }

        public  string Rewind()
        {
            return string.Format("{0} {1}", "rewind", m.ToString());
        }

        public  delegate string Playing();
        public  event Playing Show;

        public  void PlayMovie()
        {
            if (Show != null)
            {
                Show();
            }

        }
    }
}