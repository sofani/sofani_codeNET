using System;
using System.Threading;

namespace Certif70483
{
    public class VideoEventArgs : EventArgs {
        public Video Video{get; set;} 
    }
    public class VideoEncoder
    {
     //1 Define a delegate 
     //2 Define an event based on that delegate
     //3 Raise the event
     //delegate holds a refrence to a method void VideoEncoderEventHandler(object source, EventArgs args );

     public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args );
     public event VideoEncoderEventHandler VideoEncoded;
      public void  Encode(Video video) {
         Console.WriteLine("Encoding Video");
         Thread.Sleep(30000);
         OnVideoEncoded(video);
      }
        //event publisher methods
        protected virtual void OnVideoEncoded(Video video) {
                 if (VideoEncoded != null) {
                     VideoEncoded(this, new VideoEventArgs() {Video = video});
                 }
        }
    }
}