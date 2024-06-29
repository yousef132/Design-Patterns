using Design_Pattern.StrategyPattern.Behaviors.FlyBehaviors;
using Design_Pattern.StrategyPattern.Behaviors.QuackBehaviors;

namespace Design_Pattern.StrategyPattern.Duck
{
	public class ShootedDuck : BaseDuck
	{
		public ShootedDuck()
		{
			this.QuackBehavior = new Quacking();
			this.FlyBehavior = new FlyWithOneWing();
		}
		public override void Display()
		{
			Console.WriteLine("I Am A Shooted Duck");
		}
	}
}
