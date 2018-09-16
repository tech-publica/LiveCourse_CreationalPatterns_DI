﻿using System;



namespace CreationalPatterns.Creational.SimpleFactory
{
    public class Margherita : Pizza
    {
        public Margherita() : base("mozzarella", "pomodoro")
        { }

        public override void Prepare()
        {
            Console.WriteLine("preparing the simplest pizza ever");
        }
    }
}
