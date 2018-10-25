using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Exercises.AbstractFactoryExercise
{
    public class PadelRacketFactory : RacketFactory
    {
        public override Ball CreateBall()
        {
            return new PadelBall();
        }

        public override Racket CreateRacket()
        {
            return new PadelRacket();
        }
    }
}
