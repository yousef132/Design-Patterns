using Design_Pattern.StrategyPattern.Behaviors.FlyBehaviors;
using Design_Pattern.StrategyPattern.Behaviors.QuackBehaviors;

namespace Design_Pattern.StrategyPattern.Duck
{
	public class RegularDuck : BaseDuck
	{
		public RegularDuck()
		{
			this.QuackBehavior = new Quacking();
			this.FlyBehavior = new FlyWithTwoWings();
		}
		public override void Display()
		{
			Console.WriteLine("I Am Regular Duck");
		}
	}


}
