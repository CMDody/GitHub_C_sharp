using System;

namespace jaggedArrays {

	class ArrayDemo {

		static void Main() {

			int[][] a = new int[10][];

			a [0] = new int[7];
			a [1] = new int[3];
			a [2] = new int[9];
			a [3] = new int[6];
			a [4] = new int[4];
			a [5] = new int[2];
			a [6] = new int[1];
			a [7] = new int[8];
			a [8] = new int[5];
			a [9] = new int[2];

			for (int i = 0; i < a.Length; i++) {
				for (int j = 0; j < a [i].Length; j++) {
					a [i] [j] = (2 * i + 1) + (3 * j + 2);
				}
			}

			showJaggedArray (a);

			Console.WriteLine ("----------------------------------------------------------------\n");

			//---------------------------------------------

			int[][] b = new int[5][];
		
			b[0] = new int[] {1, 3, 5};
			b[1] = new int[] {0, 2, 4, 6, 8};
			b[2] = new int[] {2, 3, 5, 7, 11, 13}; 
			b[3] = new int[] {5, 10};
			b[4] = new int[] {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096};


			showJaggedArray (b);

			Console.WriteLine ("----------------------------------------------------------------\n");

			//-------------------------------------------

			int[][,] c = new int[6][,];

			c [0] = new int[2, 2];
			c [1] = new int[5, 3];
			c [2] = new int[6, 9];
			c [3] = new int[3, 3];
			c [4] = new int[7, 5];
			c [5] = new int[,] {
				{1, 3, 5},
				{2, 4, 6},
				{3, 6, 9}
			};

			for (int i = 0; i <= c [3].GetUpperBound (0); i++) {
				for (int j = 0; j <= c [3].GetUpperBound (1); j++) {
					c [3] [i, j] = (2 * i + 1) * (3 * j + 2);
				}
			}

			showJagged2DsubArray (c);

			Console.WriteLine ("----------------------------------------------------------------\n");

		}

		//===========================================

		static void showJaggedArray(int[][] array) {

			for (int i = 0; i < array.Length; i++) {
				Console.Write ("Row={0, 2} --->   ", i);
				for (int j = 0; j < array [i].Length; j++) {
					Console.Write ("{0, 2}   ", array[i][j]);
				}
				Console.WriteLine ();
			}

		}

		//===========================================

		static void showJagged2DsubArray(int[][,] array) {

			for (int i = 0; i < array.Length; i++) {
				
				int u = (array [i].GetUpperBound (0) + 1);
				int v = (array [i].GetUpperBound (1) + 1);
				Console.WriteLine (" [ {0} X {1} ] ", u, v);

				for (int j = 0; j < u; j++) {
					for (int k = 0; k < v; k++) {
						Console.Write ("{0, 2}   ", array[i][j, k]);
					}
					Console.WriteLine ();
				}
				Console.WriteLine ();

			}
		}

		//===========================================

	}

}
