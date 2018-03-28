using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text;
using Certif70483;
namespace ConsoleCertif70483 {
    class Program {
        static void Main(string[] args)
{
//1) TypeValueValidation tv = new TypeValueValidation();
    Video video = new Video() {Title = "Video 1"};
    var videoEncoder = new VideoEncoder(); //Publisher                               
    var mailservice = new MailService(); //Subscriber
    var messageservice = new MessageService(); //Subscriber 
    videoEncoder.VideoEncoded += mailservice.onVideoEncoded;
    videoEncoder.VideoEncoded += messageservice.onVideoEncoded;
    videoEncoder.Encode(video);
}
        //Delegates and Events
        public class MailService {
            public void onVideoEncoded(object source, VideoEventArgs e) {
                System.Console.WriteLine("Mail Service sending an email." + e.Video.Title);
            }
        }

         public class MessageService {
            public void onVideoEncoded(object source, VideoEventArgs e) {
                System.Console.WriteLine("Text message Service sending an email." + e.Video.Title);
            }
        } 
        public static void FileEncription() {
            const string dataToProtect = " This is a bunch of super secret content!";
            var dataToProtectAsArray = Encoding.Unicode.GetBytes(dataToProtect);

            var fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "MyDataFile.txt");

            //Encrypt a file in the file sysytem
            File.WriteAllText(fileName, dataToProtect);
            //now we can Encrypt it
            File.Encrypt(fileName);


        }
        public abstract class Animal {
            public string Name{get; protected set;}
            public abstract void SetName(string value);     

        }
        public class Cat : Animal
        {
            public override void SetName(string value)
            {
                //Validating empty
                if (string.IsNullOrWhiteSpace(value) )
                   throw new ArgumentException("value");
                //Validating conflict
                if (value == this.Name)
                   throw new ArgumentException("value is duplicate");
                //validating Size
                if (value.Length > 10)
                throw new ArgumentException("value is too long");
                this.Name = value;
            }
        }

        public class Dog : Animal
        {
            public new string Name{get; protected set;}
            //Validating Input
            public override void SetName(string value)
            {
               Contract.Requires(!string.IsNullOrWhiteSpace(value), "value is empty");
               this.Name = value;
            }
              //Validating Output
            public string getName() {
                Contract.Ensures(!string.IsNullOrWhiteSpace(Contract.Result<string>()));
                return this.Name;
            }

          
        }
    }
}
