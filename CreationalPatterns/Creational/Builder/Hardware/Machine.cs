using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Builder.Hardware
{
    public interface Machine
    {
        HardwareComponents Components { get; set; }
        void Play();
        void DevelopCode();
    }
}
