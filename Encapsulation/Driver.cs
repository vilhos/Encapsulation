using System;
using System.Collections.Generic;


namespace CityBus
{
    public class Driver
    {
        private int _age;

        public void SetAge(int value)
        {
            if (value > 22)
                _age = value;

            else
            {
                Console.WriteLine("You are not allowed to drive the bus, write acceptable age");
                _age = Int32.Parse(Console.ReadLine());
            }
        }

        public string _name;
        public Driver(int age, string name)
        {
            SetAge(age);
            _age = age;
            _name = name;
        }
    }
}
