using System;

namespace ParamsDemo {

	class MaxMin {

		public int maxVal(params int[] values) {

			if (values.Length > 0) {

				int max = values[0];

				foreach (int u in values) {
					if (u > max)
						max = u;
				}

				return max;

			} else {
				return 0;
			}

		}

		//....

		public int minVal(params int[] values) {

			if (values.Length > 0) {

				int min = values[0];

				foreach (int u in values) {
					if (u < min)
						min = u;
				}

				return min;

			} else {
				return 0;
			}

		}

	}

	//============================================

	class mainClass {

		static void Main() {

			MaxMin u = new MaxMin ();

			int a, b, c, d, e, f;

			a = u.maxVal ();
			b = u.minVal ();

			c = u.maxVal (2, 3, 5, 7, 11, 13);
			d = u.minVal (-1, 1, 3, 7, 11, 19);

			e = u.maxVal (9);
			f = u.minVal (31, 29);

			Console.WriteLine ("a={0}, b={1}, c={2}, d={3}, e={4}, f={5}", 
				a, b, c, d, e, f);


		}

	}

}
