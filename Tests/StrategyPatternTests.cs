using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Patron.StrategyPattern;

namespace Patron.Tests
{
    [TestFixture]
    public class StrategyPatternTests
    {
        [Test]
        public void duck_is_a_mallard_duck()
        {
            Duck mallard = new MallardDuck();
            Assert.AreEqual("I'm a Mallard Duck.", mallard.Display());
        }

        [Test]
        public void mallard_duck_can_fly()
        {
            Duck mallard = new MallardDuck();
            Assert.AreEqual("I'm flying!!", mallard.PerformFly());
        }

        [Test]
        public void mallard_duck_can_quack()
        {
            Duck mallard = new MallardDuck();
            Assert.AreEqual("Quack", mallard.PerformQuack());
        }

        [Test]
        public void mallard_duck_can_swim()
        {
            Duck mallard = new MallardDuck();
            Assert.AreEqual("All ducks float, even decoys!", mallard.Swim());
        }

        [Test]
        public void model_duck_can_quack()
        {
            Duck model = new ModelDuck();
            Assert.AreEqual("Quack", model.PerformQuack());
        }

        [Test]
        public void model_duck_cannot_fly()
        {
            Duck model = new ModelDuck();
            Assert.AreEqual("I can't fly.", model.PerformFly());
        }

        [Test]
        public void model_duck_cannot_fly_then_add_rocket()
        {
            Duck model = new ModelDuck();
            Assert.AreEqual("I can't fly.", model.PerformFly());

            model.SetFlyBehaviour(new FlyRocketPowered());
            Assert.AreEqual("I'm flying with a rocket!", model.PerformFly());
        }

        [Test]
        public void duck_is_a_model_duck()
        {
            Duck model = new ModelDuck();
            Assert.AreEqual("I'm a model duck", model.Display());
        }

        [Test]
        public void dumb_duck_cannot_quack()
        {
            Duck dumb = new DumbDuck();
            Assert.AreEqual("<< Silence >>", dumb.PerformQuack());
        }

        [Test]
        public void duck_is_a_dumb_duck()
        {
            Duck dumb = new DumbDuck();
            Assert.AreEqual("I'm a dumb duck.", dumb.Display());
        }






        

    }
}
