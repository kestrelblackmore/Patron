using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flybehaviour = new FlyWithWings();
            _quackbehaviour = new Quacker();
        }

        public override string Display()
        {
            return "I'm a Mallard Duck.";
        }
    }
}
