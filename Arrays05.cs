using System;

namespace VarArrays {

	class ArrayDemoVar {

		static void Main() {

			var a = new[] {1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29};
			var b = new[] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30};

			showArray ("A", a);
			showArray ("B", b);


		}

		//============================

		static void showArray(string name, int[] array) {

			Console.Write (name + " --->> ");

			int c = 0;
			foreach (int u in array) {
				Console.Write ("{0, 2}, ", u);
				c++;
			}
			Console.WriteLine ();

			//... draw line underneath the text
			c *= 4;
			c += name.Length;
			c += 7;

			for (int i = 0; i < (c + 1); i++) {
				Console.Write ("-");
			}
			Console.WriteLine ("\n");

		}

	}

}
