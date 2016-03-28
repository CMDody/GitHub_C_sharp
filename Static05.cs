using System;

namespace StaticDemo {

	static class myClass {
		// static bir sınıfın tüm üyeleri static olmak zorundadır.
		// static bir sınıftan örnek nesneler üretilemez.

		public static double PI = 3.14159;
		public static double e = 2.718;

		public static double addNum(double a, double b) {
			return (a + b);
		}

		public static double subNum(double a, double b) {
			return (a - b);
		}

		public static double mulNum(double a, double b) {
			return (a * b);
		}

		public static double divNum(double a, double b) {
			return (a / b);
		}

	}

	class mainClass {

		static void Main() {

			// myClass obj = new myClass();
			// static sınıftan örnekler üretilemez...

			Console.WriteLine ("Pi Number is " + myClass.PI);
			Console.WriteLine ("e Number is " + myClass.e);
			Console.WriteLine ("32.43 + 56.78 = " + myClass.addNum (32.43, 56.78));
			Console.WriteLine ("22.44 - 56.78 = " + myClass.subNum (22.44, 56.78));
			Console.WriteLine ("88.99 * 0.123 = " + myClass.mulNum (88.99, 0.123));
			Console.WriteLine ("0.234 / 0.005 = " + myClass.divNum (0.234, 0.005));


		}

	}

}
