using System;

namespace BitWise {

	class BitShift {

		static void Main() {

			int val = 1;

			for (int i = 0; i < 8; i++) {
			
				for (int j = 128; j > 0; j /= 2) {

					if ((val & j) > 0)
						Console.Write ("1 ");
					else if ((val & j) == 0)
						Console.Write ("0 ");


				}

				Console.WriteLine ();
				val <<= 1;

			}

		}


	}

}
