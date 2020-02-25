using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA()
            {
                Name = "ConctreteFactory1 Product A"
            };
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB();
        }
    }
}
