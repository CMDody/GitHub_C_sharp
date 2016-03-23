using System;

namespace myPack {

	class ArrayDemo {
	
		static void Main() {
			
			int[] a = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
			showArray (a);

			int[] b = new int[] {1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23};
			showArray (b);

			int[] c;
			c = new int[] {2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30};
			showArray (c);

			int[] d = new int[12];
			for (int i = 0; i < d.Length; i++) {
				d [i] = 2 * i + 1;
			}
			showArray (d);

			int[] e = new int[10];
			e [0] = 10;
			e [1] = 9;
			e [2] = 8;
			e [3] = 7;
			e [4] = 6;
			e [5] = 5;
			e [6] = 4;
			e [7] = 3;
			e [8] = 2;
			e [9] = 1;
			showArray (e);


		}

		//=======================

		static void showArray(int[] a) {
			foreach (int u in a) {
				Console.Write (u + ", ");
			}
			Console.WriteLine ("\n");
		}

	}
}
