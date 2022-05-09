using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LaptopServiceLib
{
    // create a delegate
   public delegate void NotifyDel(); // delegate NotifyDel will be instantiated in the Main() -> [LaptopServiceUI project]
   public class RepairService
    {
        public void Repair(Laptop laptop)
        {
            Console.WriteLine($"Laptop with Service tag {laptop.ServiceTag} is repaired......");

            Thread.Sleep(3000);

            //Raising Event / publishing to subscribers
            OnRepairCompletion();
        }
        //Creating event - must see that it needs a delegate to be create
        public event Action Repaired;
        
        // Event handler
        protected virtual void OnRepairCompletion()
        {
            if ( Repaired != null)
            {
                // invoking the event which needs to be handled by delgate NotifyDel
                Repaired();
            }
        }


    }
}
