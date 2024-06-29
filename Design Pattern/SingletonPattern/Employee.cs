namespace Design_Pattern.SingletonPattern
{

	public class Employee
	{
		private Employee()
		{
		}
		public int Id { get; set; }

		public string Name { get; set; }

		public decimal Salary { get; set; }


		private static Employee _instance;
		private static object _lock = new();
		// used lazy initialization for prevent from mulithreading
		public static Employee Instance
		{
			get
			{
				// Using double checking
				if (_instance == null)
				{
					// only one thread can enter this lock
					lock (_lock)
					{
						if (_instance == null)
							_instance = new Employee();
					}
				}
				return _instance;


			}
		}

	}
}
