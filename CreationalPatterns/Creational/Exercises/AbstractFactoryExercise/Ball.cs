using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Exercises.AbstractFactoryExercise
{
    //This is an abstract product, you will extend it with tennis ball and padel ball
    public abstract class Ball
    {
        public double Weight { get; set; }
        public double Radius { get; set; }

        public override string ToString()
        {
            return $"I am a shiny new {this.GetType().Name}";
        }

        public abstract void Bounce();   
    }
}
