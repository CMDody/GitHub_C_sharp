using System;
using System.Net;

namespace RecursionDemo {

	class myClass {

		public static long Factorial(int a) {

			if (a < 1) {
				return 1;
			} else {
				return (a * Factorial (a-1));
			}	
		}


		public static double Log10Factorial(int a) {

			if (a < 2) {
				return 0.0;
			} else {
				return (Math.Log10 ((double) a) + Log10Factorial (a-1));
			}

		}

	}

	class mainClass {

		static void Main() {

			for (int i = 0; i < 21; i++)

				Console.WriteLine ("{0, 2}! = {1} ", i, myClass.Factorial (i));


			Console.WriteLine ("==============================================================\n");
			Console.WriteLine ("Logarithmic Factorial scale for 10 base Logarithm...");
			Console.WriteLine ("--------------------------------------------------------------");

			for (int i = 0; i < 101; i++)

				Console.WriteLine ("Log({0, 2}!) = {1:000.00000} ", i, myClass.Log10Factorial (i));
			


		}

	}


}
