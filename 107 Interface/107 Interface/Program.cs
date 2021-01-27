using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _107_Interface
{

    public interface INotifications

    {

        // members 
        void showNotification();
        string getDate();

    }

    public class Notification : INotifications
    {
        private string sender;
        private string message;
        private string date;

        //default const
        public Notification()
        {
            sender = "Admin";
            message = "Get away from the darkside!";
            date = "";
        }

        public Notification(string mySender, string myMessage, string myDate)
        {

            this.sender = mySender;
            this.message = myMessage;
            this.date = myDate;

        }

        public void showNotification()
        {
            Console.WriteLine("{1} sent this message, {0} at {2}.", message, sender, date);
        }
        public string getDate()
        {
            return date;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Notification n1 = new Notification("Jedi", "Stay with the force!", "10/7/2020");
            n1.showNotification();
            Console.ReadKey();
        }



        
    }

   
}
