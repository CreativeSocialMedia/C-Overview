using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _103_inherritence
{

    // image class derives from post all of its functionality and adds a property, "ImageURL", and two constructors
    class Image:Post // this ":Post" means inherit all from Post class and use all of its functionalities
    {

        public string ImageURL{ get; set; }

        // create a simnple constructor
        public Image()
        {
     
        }


        // create a constructor with parameters
        public Image(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            // these are derivatives of the "Post" class accessed by "Image" class
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
            
            // this ImageURL is member variable of "Image" class not "Post" class.
            this.ImageURL = imageURL;
        }


        // virtual method override of the ToString method that is inherited from System.Object
        public override string ToString()
        {
            return String.Format("{0} - {1} -{2}  by {3}", this.ID, this.Title, this.ImageURL,  this.SendByUsername);
        }

    }
}
