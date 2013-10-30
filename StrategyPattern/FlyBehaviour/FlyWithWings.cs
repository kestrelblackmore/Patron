using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.StrategyPattern
{
    class FlyWithWings : IFlyBehaviour
    {
        public string Fly()
        {
            return "I'm flying!!";
        }
    }
}
