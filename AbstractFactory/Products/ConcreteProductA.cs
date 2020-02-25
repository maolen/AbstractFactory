using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ConcreteProductA : IAbstractProductA
    {
        public string Name { get; set; }

        public void UsefulFunctionA()
        {
            throw new NotImplementedException();
        }
    }
}
