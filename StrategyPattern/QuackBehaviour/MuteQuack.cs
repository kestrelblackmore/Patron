using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.StrategyPattern
{
    public class MuteQuack : IQuackBehaviour
    {
        public string Quack()
        {
            return "<< Silence >>";
        }
    }
}
