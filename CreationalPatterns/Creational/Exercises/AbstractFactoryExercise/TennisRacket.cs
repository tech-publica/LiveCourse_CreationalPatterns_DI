using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Exercises.AbstractFactoryExercise
{
    public class TennisRacket : Racket
    {
        public override void Hit()
        {
            Console.WriteLine("I am just hoping I don' t miss..");
        }
    }
}
