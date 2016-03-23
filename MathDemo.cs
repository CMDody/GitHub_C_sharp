using System;

class MathDemo {
	static void Main() {

		double degreeAngle = 52.2;
		double radianAngle;


		radianAngle = (Math.PI / 180) * degreeAngle;

		Console.WriteLine ("Sinus=" + Math.Sin (radianAngle));
		Console.WriteLine ("Cosine=" + Math.Cos (radianAngle));
		Console.WriteLine ("Tangent=" + Math.Tan (radianAngle));
		Console.WriteLine ("Natural Logarithm=" + Math.Log (radianAngle));

	}
}
