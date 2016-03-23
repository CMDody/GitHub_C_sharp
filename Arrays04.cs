using System;

namespace ArrayReference {

	class ArrayDemo04 {

		static void Main() {

			const int ARRAY_LEN = 10;

			int[] a = new int[ARRAY_LEN];
			int[] b = new int[ARRAY_LEN];

			for (int i = 0; i < a.Length; i++) {
				a [i] = (2 * i + 1);
				b [i] = -1 * i;
			}

			Console.WriteLine ("Array A and B first initialized ... ");
			showArray ("A", a);
			showArray ("B", b);
			Console.WriteLine ("--------------------------------------------------------------\n");


			Console.WriteLine ("Array B refered to Array A ... with b=a; ");
			b = a; // Array B refered to Array B;
			showArray ("A", a);
			showArray ("B", b);
			Console.WriteLine ("--------------------------------------------------------------\n");

			Console.WriteLine ("Now we change the value of b[4] = 99 ");
			b [4] = 99;
			showArray ("A", a);
			showArray ("B", b);
			Console.WriteLine ("Notice that even we change the value of b[4], \n" +
				"also a[4] has changed as well... \n" +
				"Remember that since b=a; was declared before...");
			Console.WriteLine ("--------------------------------------------------------------\n");

			Console.WriteLine ("Now we change the value of a[6] = 202 ");
			a [6] = 202;
			showArray ("A", a);
			showArray ("B", b);
			Console.WriteLine ("--------------------------------------------------------------\n");



		}

		//===================================

		static void showArray(string name, int[] array) {

			Console.Write (name + " --->> ");

			foreach (int u in array) {
				Console.Write ("{0, 2}, ", u);
			}
			Console.WriteLine ();

		}

	}

}
