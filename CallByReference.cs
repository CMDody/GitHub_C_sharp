using System;

namespace callByRef {

	class Test {

		public int a;
		public int b;

		//...

		public Test(int a, int b) {
			this.a = a;
			this.b = b;
		}

		public void callByValue(int a, int b) {  // input values wil never change...
			a = (int) Math.Pow ((a + b), 2);
			b = (int) Math.Pow ((a - b), 2);
		}

		public void callByReference(Test ob) {
			ob.a = (int) Math.Pow ((ob.a + ob.b), 2);
			ob.b = (int) Math.Pow ((ob.a - ob.b), 2);
		}

		public void show(string name) {
			Console.WriteLine ("Object:{0}, Value of A={1}, Value of B={2}", name, a, b);
		}

	}

	class mainClass {

		static void Main() {

			Test obA = new Test (44, 77);
			Test obB = new Test (32, 21);

			Console.WriteLine ("Initial State...");
			obA.show ("A");
			obB.show ("B");

			obA.callByValue (obB.a, obB.b);
			Console.WriteLine ();

			Console.WriteLine ("After Calling By Value...");
			obA.show ("A");
			obB.show ("B");

			obA.callByReference (obB);
			Console.WriteLine ();

			Console.WriteLine ("After Calling By Reference...");
			obA.show ("A");
			obB.show ("B");


		}

	}

}
