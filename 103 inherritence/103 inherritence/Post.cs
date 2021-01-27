using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_inherritence
{
    class Post // this becaiomes the blueprint of the posts
    {

        private static int currentPostId;


        // properties
        // protected means it is accesible only by this class or any deriving classes
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        // default construtor If a derived class does not invoke a base-class
        // constructor explecitly, the default constructor is called implicitly

        public Post()
        {
            ID = 0;
            Title = "My first Post";
            IsPublic = true;
            SendByUsername = "Jedi";

        }

        // instance of constructor that has three parameters
        public Post(int ID, string title, bool isPublic, string sendByUsername )
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
           
            return ++currentPostId;
        }


        // create method to be able to update properties in post
        public void Update(string title, bool isPublic)
        {

            this.Title = title;
            this.IsPublic = isPublic;
        }


        // virtual method override of the ToString method that is inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }

    }
}
