using CreationalPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;


namespace CreationalPatterns.Creational.AbstractFactory

{
    public class ItalianRestaurant : Restaurant
    {
        public override Pasta CookPasta() => new Ravioli();

        public override Pizza CookPizza() => new Capricciosa();      
    }
}
