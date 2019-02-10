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

			//Форматиране с дименсия
			string _format = "#0.00 м3";

			//Степенуване
			c = Math.Pow ( a, b);
			Console.WriteLine ("\n\n>a ^ b = " + c.ToString ( _format));

			//Коренуване
			c = Math.Sqrt ( b );
			Console.WriteLine ("\n\n>b ^ 1/2 = " + c.ToString ( _format));


			//Закръгляне
			c = Math.Round ( a / b);
			Console.WriteLine ("\n\n>(a / b) = " + c.ToString ());
		}
	}
}
