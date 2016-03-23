using System;

class TextFormatting {

	static void Main() {

		int a=36;
		long b=849272894904;
		double c=24.65;

		Console.WriteLine ("Integer={0} Long={1} Double={2} Number={3} \n", a, b, c, 99);

		int[] i = new int[11];

		for (int j = 0; j < i.Length; j++) {
			i[j] = j;
		}


		Console.WriteLine ("---------------------------------------------");
		foreach (int u in i) {
			Console.WriteLine ("{0}\t{1}\t{2}\t", u, (u*u), (u*u*u));
		}



	}

}
