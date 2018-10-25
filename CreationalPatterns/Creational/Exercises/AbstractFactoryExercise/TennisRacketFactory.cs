using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Exercises.AbstractFactoryExercise
{
    public class TennisRacketFactory : RacketFactory
    {
        public override Ball CreateBall()
        {
            return new TennisBall();
        }

        public override Racket CreateRacket()
        {
            return new TennisRacket();
        }
    }
}
