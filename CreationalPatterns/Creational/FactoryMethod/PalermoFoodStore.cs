﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Creational.FactoryMethod
{
    public class PalermoFoodStore : FoodStore
    {
        public override Arancino CookArancino() => new ArancinoPalermitano();
        
    }
}
