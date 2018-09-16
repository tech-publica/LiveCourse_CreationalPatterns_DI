using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Builder.Hardware
{
    public class GamingConsole : Machine
    {
        public HardwareComponents Components { get; set; } = new HardwareComponents();

        public void DevelopCode()
        {
            Console.WriteLine("Write code on a console? You cannot be serious!");

        }

        public void Play()
        {
            Console.WriteLine("now let's play, you cannot write code all day!");
        }
    }
}
