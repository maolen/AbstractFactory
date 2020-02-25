using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcreteProductB : IAbstractProductB
    {
        public void UsefulFunction()
        {
            Console.WriteLine("I am simple product B");
        }
        public void AnotherUsefulFunction(IAbstractProductA productA)
        {
            Console.WriteLine($"I am using product {productA.Name}");
        }
    }
}
