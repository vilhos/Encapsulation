using System;
using System.Collections.Generic;


namespace CityBus
{
    public class Transport
    {
        public int Speed { get; protected set; }
        public virtual void Drive()
        {
            Speed = 0;
            Console.WriteLine("Waiting...");
            Console.WriteLine($"Speed = {Speed}");
        }
    }
    public class Bus : Transport
    {
        public int busCapacity = 25;
        public Driver Driver;
        public List<Passanger> Passangers;
        public Bus(Driver driver, List<Passanger> passangers, CheckManager check)
        {
            Driver = driver;
            Passangers = passangers;
            Run(check);
        }

        private void Run(CheckManager check)
        {
            if (Passangers.Count > 25 || check.ifHaveTicket == false)
            {
                Console.WriteLine($"I am your driver, my name is {Driver._name}");
                base.Drive();
            }

            else if (Passangers.Count <= 25 && check.ifHaveTicket)
            {
                Console.WriteLine($"I am your driver, my name is {Driver._name}");
                Drive();
            }
        }

        public override void Drive()
        {
            Speed = 1;
            Console.WriteLine("Runing...");

            while (Speed <= 60)
            Console.WriteLine($"Speed = {Speed++}");
        }
    }
}
