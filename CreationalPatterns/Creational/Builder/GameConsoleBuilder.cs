
using CreationalPatterns.Creational.Builder.Hardware;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Builder
{
    public class GameConsoleBuilder : HardwareBuilder
    {

        private GamingConsole console = new GamingConsole();

        public HardwareBuilder AddHD(int giga)
        {
            console.Components.HD = giga;
            return this;
        }

        public HardwareBuilder AddRam(int giga)
        {
            console.Components.RAM = giga;
            return this;
        }

        public HardwareBuilder AddSSD(int giga)
        {
            console.Components.SSD = giga;
            return this;
        }

        public GamingConsole Build()
        {
            return console;
        }
    }
}
