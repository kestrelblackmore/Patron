using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patron.StrategyPattern
{
    public abstract class Duck
    {
        protected IFlyBehaviour _flybehaviour;
        protected IQuackBehaviour _quackbehaviour;
        
        public Duck()
        {
        }

        public abstract string Display();

        public string PerformFly()
        {
            return _flybehaviour.Fly();
        }

        public string PerformQuack()
        {
            return _quackbehaviour.Quack();
        }

        public string Swim()
        {
            return "All ducks float, even decoys!";
        }

        public void SetFlyBehaviour(IFlyBehaviour fly)
        {
            _flybehaviour = fly;
        }

        public void SetQuackBehaviour(IQuackBehaviour quack)
        {
            _quackbehaviour = quack;
        }
    }
}
