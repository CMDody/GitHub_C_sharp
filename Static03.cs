using System;

namespace StaticDemo {


	class myClass {

		int i, j;

		public static myClass Factory (int a) {
			// Factory methods can construct classes

			myClass obj = new myClass();

			obj.i = a;
			obj.j = 2 * a;

			return obj;

		}

		public void show() {
			Console.WriteLine ("Values are {0}, {1} ", i, j);
		}


	}

	class mainClass {

		static void Main() {

			myClass ob1, ob2, ob3;

			ob1 = myClass.Factory (5);
			ob2 = myClass.Factory (3);
			ob3 = myClass.Factory (9);

			ob1.show ();
			ob2.show ();
			ob3.show ();

		}

	}

}
