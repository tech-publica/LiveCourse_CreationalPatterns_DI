using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Exercises.AbstractFactoryExercise
{
    public class PadelBall : Ball
    {
        public override void Bounce()
        {
            Console.WriteLine("this is rather soft, good because I will soon get on in the figure!");
        }
    }
}
