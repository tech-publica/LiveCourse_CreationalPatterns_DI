using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Exercises.AbstractFactoryExercise
{

    public enum Sport { TENNIS, PADEL}

    //This is the abstract Factory, you have to complete it, and to extend it with tennis and padel racket factories
    public abstract class RacketFactory
    {

        // This is just a convenience method to choose your Factory of choice
        public static RacketFactory GetInstance(Sport sport)
        {
           switch(sport)
           {
                case Sport.PADEL: return null;   // you will have to change this
                default: return null;   // you will have to change this
            }
        }


        // here you will need to declare something...
    }
}
