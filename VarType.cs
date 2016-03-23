using System;


namespace Talua {
	class VarType {

		static void Main(String[] arg) {

			var u = 3.14159;
			var v = 34;
			var w = 23.54m;
			var name = "Cemil Murat";
			var surname = "Dodanli";

			Console.WriteLine ("{0, 3:#.##} {1, 3} {2, 3:##.###}", u, v, w);

		Console.WriteLine (@"Name: {0}
Surname: {1}", name, surname);

		Console.WriteLine ("\n");


		}
	}
		
}
