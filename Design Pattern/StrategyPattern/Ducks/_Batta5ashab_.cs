using Design_Pattern.StrategyPattern.Behaviors.FlyBehaviors;
using Design_Pattern.StrategyPattern.Behaviors.QuackBehaviors;

namespace Design_Pattern.StrategyPattern.Duck
{
	public class _Batta5ashab_ : BaseDuck
	{
		public _Batta5ashab_()
		{
			this.QuackBehavior = new UnableToQuack();
			this.FlyBehavior = new UnableToFly();
		}
		public override void Display()
		{
			Console.WriteLine("I Am _Batta5ashab_");
		}
	}


}
