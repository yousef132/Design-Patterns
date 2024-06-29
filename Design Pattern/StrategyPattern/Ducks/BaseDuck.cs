using Design_Pattern.StrategyPattern.Behaviors.FlyBehaviors;
using Design_Pattern.StrategyPattern.Behaviors.QuackBehaviors;

namespace Design_Pattern.StrategyPattern.Duck
{
	public abstract class BaseDuck
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public IFlyBehavior FlyBehavior;
		public IQuackBehavior QuackBehavior;

		public void Perform()
		{
			Console.WriteLine($"I am duck with id :{Id} ");
			Console.WriteLine(FlyBehavior.Fly());
			Console.WriteLine(QuackBehavior.Quack());
		}
		public abstract void Display();
	}


}
