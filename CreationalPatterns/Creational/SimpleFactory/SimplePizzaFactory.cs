﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace CreationalPatterns.Creational.SimpleFactory
{
    public enum PizzaType { margherita, capricciosa}

    public class SimplePizzaFactory
    {
        //encapsulate what changes
        //single responsibility principle

        public static Pizza CreatePizza(PizzaType type)
        {
            // not really open closed principle!
            switch(type)
            {
                case PizzaType.margherita:
                    return new Margherita();
                case PizzaType.capricciosa:
                    return new Capricciosa();
                default:
                    throw new ArgumentException("pizza type not permitted");
            }
        }
    }
}
