using Design_Pattern.StrategyPattern.Behaviors.FlyBehaviors;
using Design_Pattern.StrategyPattern.Behaviors.QuackBehaviors;

namespace Design_Pattern.StrategyPattern.Duck
{
	public class BattaLe3ba : BaseDuck
	{
		public BattaLe3ba()
		{
			this.FlyBehavior = new UnableToFly();
			this.QuackBehavior = new Quacking();
		}
		public override void Display()
		{
			Console.WriteLine("I Am a BattaLe3ba");
		}
	}


}
