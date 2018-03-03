namespace GreenTomato.Library.Models

/*Singlton Pattern  
  comes under creational pattern as this pattern provides one of the best ways to create an object.
  SingleObject class have its constructor as private and have a static instance of itself.
  SingleObject class provides a static method to get its static instance to outside world.
*/
{ 
     public class RadioPlayer {
         private  static RadioPlayer  = new RadioPlayer();
         private  RadioPlayer() {

         }
         public static RadioPlayer Create() {
             if (rp == null) {
                 lock(rp);
                 rp = new RadioPlayer();
             }
             return rp;
         }

         
     }
}