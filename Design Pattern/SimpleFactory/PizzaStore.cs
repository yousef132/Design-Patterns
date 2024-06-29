using Design_Pattern.SimpleFactory.Types;

namespace Design_Pattern.SimpleFactory
{
	public class PizzaStore
	{
		public Pizza OrderPizzaBySize(int size)
		{
			#region After Using Simple Factory
			Pizza pizza = new PizzaFactory().CreatePiza(size);
			#endregion

			#region Before Using Simple Factory
			//if (size > 5)
			//	pizza = new LargePiza();
			//else if (size < 5)
			//	pizza = new SmallPiza();
			//else
			//	pizza = new MediumPizza();
			#endregion


			pizza.Prepare();
			pizza.Bake();
			pizza.Box();


			return pizza;
		}
		public Pizza OrderPizzaByType(string Type)
		{
			#region After Using Simple Factory
			Pizza pizza = new PizzaFactory().CreatePiza(Type);
			#endregion

			#region Before Using Simple Factory
			//if (Type == "Cheeze")
			//	pizza = new CheezePizza();
			//else if (Type == "Italian")
			//	pizza = new ItalianPizza();
			//else if (Type == "Greek")
			//	pizza = new GreekPizza();
			//else
			//	pizza = new PepperoniPizza();

			#endregion


			pizza.Prepare();
			pizza.Bake();
			pizza.Box();

			return pizza;
		}
	}
}
