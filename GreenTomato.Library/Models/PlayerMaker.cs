namespace GreenTomato.Library.Models {
    public class PlayerMaker {
        public static IPlayer Create(PlayerSelection ps)  {
             switch (ps)
             {
                 case PlayerSelection.Movie:
                 return new MoviePlayer(new MovieCA());
                    case PlayerSelection.Radio:
                 return new RadioPlayer();
                    case PlayerSelection.Tv:
                 return new TvPlayer());
                 default:
             }
        }
    }
}