using System;

namespace TableProject
{
	class MainClass
	{
		enum ti {ime = 0, familia, godini}
		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string[,] table = new string[2, 3];

			//Въвеждане на първи ред
			table[0, (int) ti.ime] = "Фатме"; table[0, (int) ti.familia] = "Черкез"; table[0, (int) ti.godini] = "19";
		
 
			//Въвеждане на втори ред
			table[1, (int) ti.ime] = "Черкезова"; table[1,(int) ti.familia ] = "Фатмето"; table[1, (int) ti.godini] = "21";


			//Печат
			Console.Write ("Кой ред искате да видите: ");
			int _index = Convert.ToInt32 (Console.ReadLine ()) - 1; 
			Console.WriteLine ((table [0, (int) ti.ime]) [0] + "." + table [0, (int) ti.familia] + "," + table[0,(int) ti.godini ] + "г.");

			}
	}
}
//           string[] row = new string[3];	
//
//			row [0] = "Ред 1";
//			row [1] = "Ред 2";
//			row [2] = "Ред 3";
//			Console.WriteLine ("Масив row: " + row[0] + ", "+ row[1] + ", " + row[2] + ", " + "\n" );
//
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split (',');
//			Console.WriteLine ("Броят на масива:\n" + "1,2,3,4,5,6,7,8,9\n\n е:" + parse.Length);   
//
//			string list1 = string.Join (";", parse);
//			Console.WriteLine ("Новият стринг е:\n" + list1 + "\n\n");