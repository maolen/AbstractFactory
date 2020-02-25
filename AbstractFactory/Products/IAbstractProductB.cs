using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IAbstractProductB
    {
        void UsefulFunction();
        void AnotherUsefulFunction(IAbstractProductA productA);
    }
}
