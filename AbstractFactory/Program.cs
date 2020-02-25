using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client(new ConcreteFactory1()).Do();
        }
    }
}
