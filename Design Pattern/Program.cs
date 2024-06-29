﻿using Design_Pattern.StrategyPattern.Duck;

namespace Design_Pattern
{
	internal class Program
	{
		static void Main(string[] args)
		{

			#region Strategy Pattern


			ShootedDuck duck = new ShootedDuck();
			duck.Perform();
			Console.WriteLine("--------------");

			_Batta5ashab_ duck2 = new _Batta5ashab_();
			duck2.Perform();
			Console.WriteLine("--------------");


			BattaLe3ba duck3 = new BattaLe3ba();
			duck3.Perform();


			#endregion

		}
	}
}