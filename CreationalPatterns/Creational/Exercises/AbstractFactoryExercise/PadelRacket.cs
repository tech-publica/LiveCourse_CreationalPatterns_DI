﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.Exercises.AbstractFactoryExercise
{
    public class PadelRacket : Racket
    {
        public override void Hit()
        {
            Console.WriteLine("Soner or later I will manage to bounce one out of the court!");
        }
    }
}
