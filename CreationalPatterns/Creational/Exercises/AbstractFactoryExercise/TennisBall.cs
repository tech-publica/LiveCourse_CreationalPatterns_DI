using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Exercises.AbstractFactoryExercise
{
    public class TennisBall : Ball
    {
        public override void Bounce()
        {
            Console.WriteLine("bounce really fast!");
        }
    }
}
