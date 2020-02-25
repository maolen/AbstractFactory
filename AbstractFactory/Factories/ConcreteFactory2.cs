using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA()
            {
                Name = "ConctreteFactory2 Product A"
            };
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB();
        }
    }
}
