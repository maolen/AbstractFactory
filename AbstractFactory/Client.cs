using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        private IAbstractFactory abstractFactory;

        public Client(IAbstractFactory abstractFactory)
        {
            this.abstractFactory = abstractFactory;
        }

        public void Do()
        {
            IAbstractProductA productA = abstractFactory.CreateProductA();
            IAbstractProductB productB = abstractFactory.CreateProductB();

            // 150 lines
            productB.UsefulFunction();
            // 150 lines
            productB.AnotherUsefulFunction(productA);
        }
        //public void Main()
        //{
        //    Console.WriteLine("Client: Testing client code with the first factory type...");
        //    ClientMethod(new ConcreteFactory1());

        //    Console.WriteLine("Client: Testing the same client code with the second factory type...");
        //    ClientMethod(new ConcreteFactory2());
        //}
        //public void ClientMethod(IAbstractFactory factory)
        //{
        //    IAbstractProductA productA = factory.CreateProductA();
        //    IAbstractProductA productB = factory.CreateProductB();

        //    Console.WriteLine(productB.UsefulFunctionB());
        //    Console.WriteLine(productB.AnotherUsefulFunctionB(productA));
        //}
    }
}
