using System;

namespace multiDimArrays {

	class ArrayDemo {

		static void Main() {

			int[,] a = new int[5, 6];

			for (int i = 0; i < 5; i++) {
				for (int j = 0; j < 6; j++) {
					a [i, j] = ((2*i + 1) + (3*j+1));
				}
			}
				
			show2D_Array (a);
			Console.WriteLine ("Sum of 2D array = " + sumOf2D_Array (a));
			Console.WriteLine ("\n");

			//-----------------------------------------------------------------

			int[,] b = { 
				{1, 3, 5, 7, 9, 11}, 
				{2, 4, 6, 8, 10, 12}, 
				{3, 6, 9, 12, 15, 18}, 
				{4, 8, 12, 16, 20, 24}, 
				{5, 10, 15, 20, 25, 30}
			};

			show2D_Array (b);
			Console.WriteLine ("Sum of array = " + sumOf2D_Array (b) + "\n");

			//-----------------------------------------------------------------

			int[,,] c = { 
				{{1, 1}, {1, 2}, {1, 3}},
				{{2, 1}, {2, 2}, {2, 3}},
				{{3, 1}, {3, 2}, {3, 3}},
				{{4, 1}, {4, 2}, {4, 3}}
			};

			show3D_Array (c);
			Console.WriteLine (c.GetUpperBound (0) + ", " + c.GetUpperBound (1) + ", " + c.GetUpperBound (2));

			//-----------------------------------------------------------------

			int[,,] d = new int[3, 6, 9];

			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 6; j++) {
					for (int k = 0; k < 9; k++) {
						d[i, j, k] = ((2*i + 1) + (3*j + 2) + (4*k + 3));
					}
				}
			}

			show3D_Array (d);
			Console.WriteLine (d.GetUpperBound (0) + ", " + d.GetUpperBound (1) + ", " + d.GetUpperBound (2));


		}

		//========================================================

		static void show2D_Array(int[,] array) {

			for (int i = 0; i <= array.GetUpperBound (0); i++) {

				for (int j = 0; j <= array.GetUpperBound (1); j++) {
					Console.Write ("(Row={0, 2}, Column={1, 2}) Value={2, 2}   ", i, j, array[i,j]);
				}
				Console.WriteLine ();
			}
			Console.WriteLine ("-----------------------------------------------");
			Console.WriteLine ("Length=" + array.Length + ", Rank=" + array.Rank);

		}

		//=========================================================

		static int sumOf2D_Array(int[,] array) {

			int sum = 0;
			for (int i = 0; i <= array.GetUpperBound (0); i++) {
				for (int j = 0; j <= array.GetUpperBound (1); j++) {
					sum += array [i, j];
				}
			}

			return sum;

		}

		//=========================================================

		static void show3D_Array(int[,,] array) {

			for (int i = 0; i <= array.GetUpperBound (0); i++) {
				for (int j = 0; j <= array.GetUpperBound (1); j++) {
					for (int k = 0; k <= array.GetUpperBound (2); k++) {
						Console.Write ("(Row={0, 2}, Column={1, 2}, Depth={2, 2}) Value={3, 2} \t",i, j, k, array[i,j,k]);
					}
					Console.WriteLine ();
				}
				Console.WriteLine ("-------------------------------------------------------------------->>");
			}
			Console.WriteLine ("\n \n");

		}

	}

}
