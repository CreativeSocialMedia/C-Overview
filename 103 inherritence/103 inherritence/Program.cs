using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _103_inherritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Your post here", true, "Jedi");


           

            Image imagePost1 = new Image("Check it out my post", "Jedi", "http://yahoo.com", true );

         



            VideoPost myVideo = new VideoPost("VideoHere", "Jedi", "URL here", true, 20);

            // stack these in order you want them to print
            Console.WriteLine(post1.ToString());
            Console.WriteLine(imagePost1.ToString());
            Console.WriteLine(myVideo.ToString());

            myVideo.Play();
            Console.WriteLine("Press any key to stop video!");
            Console.ReadKey();

           myVideo.Stop();
           Console.ReadLine();
        }
    }
}
