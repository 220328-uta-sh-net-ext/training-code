using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopServiceLib
{
    // classes which are static cannot be instantiated and cannot be inherited
   public static class EmailService
    {
        // static methods needs only reference of a class to be invoked (single entry point of invocation)
        static public void SendEmail()
        {
            Console.WriteLine("-----------Email Sent----------");
        }
    }
}
