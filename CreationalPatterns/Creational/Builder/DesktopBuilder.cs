

using CreationalPatterns.Creational.Builder.Hardware;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Builder
{
    public class DesktopBuilder : HardwareBuilder
    {

        private Desktop desktop = new Desktop();

        public HardwareBuilder AddHD(int giga)
        {
            desktop.Components.HD = giga;
            return this;
        }

        public HardwareBuilder AddRam(int giga)
        {
            desktop.Components.RAM = giga;
            return this;
        }

        public HardwareBuilder AddSSD(int giga)
        {
            desktop.Components.SSD = giga;
            return this;
        }

        public Desktop Build()
        {
            return desktop;
        }
    }
}
