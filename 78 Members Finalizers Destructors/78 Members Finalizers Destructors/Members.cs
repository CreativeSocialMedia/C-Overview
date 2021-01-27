using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78_Members_Finalizers_Destructors
{
    class Members
    {

        // member private fields
        private string memberName;
        private string jobTitle;
        private int salary;

        // member public field
        public int age;


        // member property - exposes jobTitle safely
        // Properties alwways start with Capital letters

        public string JobTitle
        {
            get
            {
                return jobTitle;

            }

            set
            {
                jobTitle = value;
            }
        }


        public string MemberName
        {
            get
            {
                return memberName;

            }

            set
            {
                memberName = value;
            }
        }


        

        // public member method - can be called from other classes
        // thi method is used to call private m,ethods and if condition is met it allows the private info to be accessed outside this class.
        public void Intoducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }

            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
           
        }

        private void SharingPrivateInfo()
        {

            Console.WriteLine("My salary will be: {0}", salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Dev";
            Console.WriteLine("My salary will be: {0}", salary);
        }

        //member DESTRUCTOR
        // this method should never be left empty. If you use it add somethng tot he que or don't use it if not needed
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Decosnstruction of members Object!");
            System.Diagnostics.Debug.Write("Destruction of members Object!");
        }
    }
}
