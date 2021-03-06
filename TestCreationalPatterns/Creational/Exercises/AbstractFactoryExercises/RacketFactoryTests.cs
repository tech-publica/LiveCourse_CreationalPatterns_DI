﻿using CreationalPatterns.Creational.Exercises.AbstractFactoryExercise;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace TestCreationalPatterns.Creational.Exercises.AbstractFactoryExercises
{

    public class RacketFactoryTests
    {
        private readonly RacketFactory factory;
        public RacketFactoryTests()
        {
            factory = RacketFactory.GetInstance(Sport.PADEL);
        }

        // Test the creation of racket using a PadelRacketFactory and check it produces Padel Rackets
        [Fact]
        public void CreateRacket()
        {

        }

        // Test the creation of racket using a PadelRacketFactory and check it produces Padel Rackets

        [Fact]
        public void CreateBall()
        {

        }
    }
}
