namespace Design_Pattern.SimpleFactory.Types
{
	public class Pizza
	{
		public string Name { get; set; }

		public string GetName() => Name;

		public void Prepare()
		{
			Console.WriteLine("Preparing " + Name);
		}
		public void Bake()
		{
			Console.WriteLine("Baking " + Name);
		}
		public void Box()
		{
			Console.WriteLine("Boxing " + Name);
		}

	}
}
