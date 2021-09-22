using System;
using System.Collections.Generic;


namespace CityBus
{
    public class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver(42, "Garnik");
            List<Passanger> passangers = new List<Passanger>();
            List<Passanger> tickets = new List<Passanger>();
            for (int i = 0; i < 25; i++)
            {
                tickets.Add(new Passanger());
                passangers.Add(new Passanger());
            }

            CheckManager check = new CheckManager();
            check.CheckTicket(passangers, tickets);
            Transport transport = new Bus(driver, passangers, check);

            Console.ReadKey();
        }
    }
}
