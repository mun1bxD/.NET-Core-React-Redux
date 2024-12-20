using System;

namespace OOP_Abstraction
{
    internal class Program
    {
        public abstract class Notification
        {
            public string notification { get; set; }
            public abstract void SendNotification();
            public void Display()
            {
                Console.WriteLine("Notification" + notification);
            }
        }

        public class EmailNotification : Notification
        {
            public string EmailAddress { get; set; }
            
            public override void SendNotification()
            {
                Console.WriteLine($"Sending email to {EmailAddress}: {notification}");
            }
        }
        public class SMSNotification : Notification
        {
            public string PhoneNumber { get; set; }

            public override void SendNotification()
            {
                Console.WriteLine($"Sending SMS to {PhoneNumber}: {notification}");
            }
        }
        static void Main(string[] args)
        {
            EmailNotification notification = new EmailNotification 
            {
                EmailAddress="hello@nothing.com",
                notification="email Alert"
            };

            notification.Display();
            notification.SendNotification();

            Console.WriteLine("Enter key to close");
            Console.ReadKey ();
        }
    }
}

/*
Points:
1. Abstract method shoud be deine inside abstract class

2. An abstract method does not have an implementation in the abstract class. Instead, it is meant to be
    implemented by derived (non-abstract) classes that inherit from the abstract class. The abstract 
    class defines the method signature but does not provide any logic for it.

3. Abstract methods cannot be called directly because they don't have an implementation. However,
    you can call them indirectly by creating an instance of a derived class that implements the 
    abstract method. The main class can work with instances of derived classes that provide concrete implementations.

4. An abstract class can exist without any abstract methods. It can have concrete methods 
    (methods with an implementation) and properties, but it cannot be instantiated directly.
 */