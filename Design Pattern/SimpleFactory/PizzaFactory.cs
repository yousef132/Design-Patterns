using Design_Pattern.SimpleFactory.Types;

namespace Design_Pattern.SimpleFactory
{
	public class PizzaFactory
	{

		public Pizza CreatePiza(string Type)
		{
			if (Type == "Cheeze")
				return new CheezePizza();
			else if (Type == "Italian")
				return new ItalianPizza();
			else if (Type == "Greek")
				return new GreekPizza();
			return new PepperoniPizza();

		}
		public Pizza CreatePiza(int size)
		{
			if (size > 5)
				return new LargePiza();
			else if (size < 5)
				return new SmallPiza();

			return new MediumPizza();
		}
	}
}
