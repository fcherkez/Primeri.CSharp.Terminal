﻿using System;

namespace Module03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a = 0, b = 0, c = 0;

			Console.Write ("> a = "); a = Convert.ToDouble (Console.ReadLine ());
			Console.Write ("> b = "); b = Convert.ToDouble (Console.ReadLine ());


			Console.WriteLine ("\n\n>a / b = " + (a / b).ToString ());

		}
	}
}
