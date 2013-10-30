using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.StrategyPattern
{
    public class DumbDuck : Duck
    {
        public DumbDuck()
        {
            _flybehaviour = new FlyNoWay();
            _quackbehaviour = new MuteQuack();

        }
        public override string Display()
        {
            return "I'm a dumb duck.";
        }
    }
}
