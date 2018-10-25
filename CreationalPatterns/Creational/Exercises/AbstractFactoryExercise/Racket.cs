using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Exercises.AbstractFactoryExercise
{
    // This is an abstract product, you will have to extend it with padel and tennis rackets
    public abstract class Racket
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"I am a shiny new {this.GetType().Name}"; 
        }
        public abstract void Hit();
    }
}
