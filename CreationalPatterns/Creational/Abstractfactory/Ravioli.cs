using System;



namespace CreationalPatterns.Creational.AbstractFactory
{
    public class Ravioli : Pasta
    {
        public Ravioli() 
            : base("tuccu", true)
        {
        }

        public override void Cook()
        {
            Console.WriteLine("stuffed pasta is the best");
        }
    }
}
