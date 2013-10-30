using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.StrategyPattern
{
    public class FlyRocketPowered : IFlyBehaviour
    {
        public string Fly()
        {
            return "I'm flying with a rocket!";
        }
    }
}
