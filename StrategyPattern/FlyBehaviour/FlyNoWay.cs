using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.StrategyPattern
{
    class FlyNoWay : IFlyBehaviour
    {
        public string Fly()
        {
            return "I can't fly.";
        }
    }
}
