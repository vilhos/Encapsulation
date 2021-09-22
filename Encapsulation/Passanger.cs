using System;
using System.Collections.Generic;


namespace CityBus
{
    public class Passanger
    {
        private Guid _ticket;

        public Passanger()
        {            
            _ticket = Guid.NewGuid();
        }
    }
}
