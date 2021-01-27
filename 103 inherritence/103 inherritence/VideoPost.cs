using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _103_inherritence
{
    class VideoPost:Post
    {
        // member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        // declare timer from the "timer" class
        Timer timer;
   

       protected int Length { get; set; }
        protected string VideoUrl { get; set; }
     


        public VideoPost()
        { }

        public VideoPost(string title, string sendByUsername, string videoUrl, bool isPublic, int length)
        {

            // member variables inherrited from Post
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;

            // member variable of videopost not post
            this.VideoUrl = videoUrl;
            this.Length = length;
            
           
        }


        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                // initialize timer and call it back at every 1000
                timer = new Timer(TimerCallBack, null, 0, 1000);
            }

        }

        // this method is called every 1000 per line 51
        private void TimerCallBack(Object o)
        {
            if (currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0} sec.", currDuration);

                // Garbage collector
                GC.Collect();

            }

            else {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine("Stopped at {0} sec", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }



        // virtual method override of the ToString method that is inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} by {4}", this.ID, this.Title, this.VideoUrl, this.Length, this.SendByUsername);
        }
    }
}
