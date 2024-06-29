namespace Design_Pattern.StrategyPattern.Behaviors.QuackBehaviors
{
	public class UnableToQuack : IQuackBehavior
	{
		public string Quack() => "Can't Quack !";
	}

}
