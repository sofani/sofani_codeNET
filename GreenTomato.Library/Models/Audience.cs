

using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using GreenTomato.Library.Interfaces;
/*XML FILES
   <root>
     <movie>
        <file></file>
        <gener> </gener>
        <ArrayActor>
          <actor></actor>
        </ArrayActor>
    </movie>
 </root>



 */
namespace GreenTomato.Library.Models 
{
    public class Audience {

        private IPlayer mp;
        public string response;

        public Audience(IMovie movie)
        {
            mp = new MoviePlayer(movie);
        }
        Func<IPlayer, string>  play = (mp) => 
        {
            return mp.Play();
        };

        Func<IPlayer, string> Pause = (mp) => 
        { 
            return mp.Pause();
         };


        public delegate void Play1();
        public delegate string AudienceStuff();
        public delegate string Pause1(int i, bool b);

        
        public string Watch()
        {
            return mp.Play();
        }

        public void SnackBreak()
        {
            mp.Pause();
        }

        public void Talk()
        {
            mp.Forward();
        }

        public void Leave()
        {
            mp.Rewind();
        }

        public string DoAction(AudienceStuff action)
        {
            return action();
        }

        public void GoPlaying(MoviePlayer mo)
        {
            mo.Show += Watching;
        }

        public string Watching()
        {
            response = "we are watching";
            return response;
        }

        public void saving(MoviePlayer mo) {
           mo.Show += SaveToFile;
           mo.Show += SaveToXML;
        }
        
        private string SaveToFile() {
            //using is an import 
            //using block as garabage collector
            using (var f  = new FileStream("CollectionMode.txt", FileMode.Append) ){
                var s  = new StreamWriter(f);
                s.Write(new MovieUS().ToString() + "\n");
            }
          //  File.AppendAllText("collection.txt", new MovieUS().ToString() + "\n");
            return " ";
        }

        private string SaveToXML()
        {
            var s = new XmlSerializer(typeof(MovieUS));
            var f  = new StreamWriter("collection.xml");
            s.Serialize(f, new MovieUS());

            return string.Empty;
        }

        private void ReadFromFile() {
            var r = File.ReadAllLines("collection.txt");
            foreach(var line in r)  {
                //dont  do this
            }
        }
        private void ReadFromFileXml() {
            var s = new XmlSerializer(typeof(MovieUS));
            var r = new StreamReader("collection.xml");
            var o = (MovieUS) s.Deserialize(r); //exception if not exxist
            var o2 = s.Deserialize(r) as MovieUS; //null if not exists



        }
    }

}