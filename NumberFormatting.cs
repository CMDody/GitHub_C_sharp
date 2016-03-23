using System;

class NumFormat {

	static void Main() {

		int a = 12;
		long b = 15L;
		decimal c = 25.4674m;
		double d = 2922.294757392;

		Console.WriteLine (@"First Number: {0, 5}
		Second Number:{1, 9}", a, b);

		Console.WriteLine ("Without Formatting Value: {0}, " +
			"---> With Currency Formatting: {1:C}", c, c);

		Console.WriteLine ("{0} {1, 5:#,###.###} {2, 5:C}", d, d, d);

		Console.WriteLine (); // bir boş satır bırak;


	}

}
