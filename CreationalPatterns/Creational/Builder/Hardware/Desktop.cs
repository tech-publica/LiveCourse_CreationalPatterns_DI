using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Builder.Hardware
{
    public class Desktop : Machine
    {
        public HardwareComponents Components { get; set; } = new HardwareComponents();

        public void Play()
        {
            Console.WriteLine("The super expensive graphics card now makes a little more sense..");
        }

        public void DevelopCode()
        {
            Console.WriteLine("NOW we are doing something really interesting!");
        }

    }
}
