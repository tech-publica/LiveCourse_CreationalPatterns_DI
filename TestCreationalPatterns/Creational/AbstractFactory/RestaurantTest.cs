
using CreationalPatterns.Creational.Abstractfactory;using CreationalPatterns.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestCreationalPatterns.Creational.AbstractFactory
{

    public class RacketFactoryTest
    {
        [Fact]
        public void CookPizza()
        {
            Restaurant resto = Restaurant.Instance;
            Pizza pizza = resto.CookPizza();
            Assert.IsType<Capricciosa>(pizza);
        }
        [Fact]
        public void CookPasta()
        {
            Restaurant resto = Restaurant.Instance;
            Pasta pasta = resto.CookPasta();
            Assert.IsType<Ravioli>(pasta);
        }
    }
}
