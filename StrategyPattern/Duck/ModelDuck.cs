using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.StrategyPattern
{
    public class ModelDuck : Duck
    {

        public ModelDuck()
        {
            _flybehaviour = new FlyNoWay();
            _quackbehaviour = new Quacker();
        }

        public override string Display()
        {
            return "I'm a model duck";
        }

    }
}
