namespace GreenTomato.Library.Models
{
    public static class TVPlayer  : APlayer {
        //public static void 
        // public void Play() {

        // }
        private TVPlayer(Screens screen, Power power, Button button )  {
            screen = null;
            power = null;
            button = null;
        }

        protected override APlayer Create() {
            return new TVPlayer(new Screens(), new Power(), new Button());
        }
        public override APlayer Create() {
            return new TVPlayer();

        }

    }
}