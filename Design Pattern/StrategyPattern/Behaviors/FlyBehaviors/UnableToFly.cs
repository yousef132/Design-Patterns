namespace Design_Pattern.StrategyPattern.Behaviors.FlyBehaviors
{
	public class UnableToFly : IFlyBehavior
	{
		public string Fly() => "I Can't FLy";
	}
}
