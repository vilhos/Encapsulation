using System;
using System.Collections.Generic;


namespace CityBus
{
    public class CheckManager
    {
        public bool ifHaveTicket { get; private set; }
        public bool CheckTicket(List<Passanger> passangers, List<Passanger> tickets)
        {
            if (passangers.Count == tickets.Count)
                ifHaveTicket = true;

            return ifHaveTicket;
        }
    }
}
