using System;
using LaptopServiceLib;

namespace LaptopServiceUI
{
    class Program
    {
        static double CircleArea(double radius)
        {
            return radius * radius;
        }
        static void Main(string[] args)
        {
            // instantiate the delegate
            //         vvv
            // Target Method tied to the delegate
            //NotifyDel notifyDel = new NotifyDel(EmailService.SendEmail);
            //Action notifyDel = new Action(EmailService.SendEmail);

            // C# offers predefined delegates like Action(delegate of type void), func(delegate that have a return type)

            // Types of Delegates:
            //      Single cast delegate - a delegate which is tied to a method
            //      Multicast delegate - a delegate tied to more than one method
            //notifyDel += TextService.SendText; // subscribing the methods to make multicast delegate
            // delegates maintains an invocation list that contains reference to all subscribed methods                                    
            // Invoke the delegate
            //  notifyDel();
            //notifyDel.Invoke();

            //Console.WriteLine("----------Using Func Delegate------------");
            //     vvv    vvv
            //input parameter ,Return value
            // Func<double,double> area = new Func<double,double>(CircleArea);
            // Console.WriteLine($"Area of circle is { area.Invoke(4.5)}");
            // Predicate - a delegate of type bool
            // Predicate pDel= new Predicate(target function);

            //Subscription to publisher

            RepairService repairService = new RepairService();// publisher

            Laptop laptop1 = new Laptop() { ServiceTag = "2S3S5T1" };

            repairService.Repaired += EmailService.SendEmail;// subscriber 1

            repairService.Repaired += TextService.SendText; //subscriber 2

            repairService.Repaired += PushNotificationService.SendPushNotification;// subscriber 3

            repairService.Repaired += AutomatedCall.VoiceCall;

            repairService.Repaired -= TextService.SendText;// unsubscribe

            repairService.Repair(laptop1); // Event is raised
            
        }
    }
}
