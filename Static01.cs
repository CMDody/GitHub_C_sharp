using System;

namespace staticDemo {

	class myClass {

		public static int val = 12;

		public static void showMsg() {
			Console.WriteLine ("Static Method Message...");
		}

	}


	class mainClass {

		static void Main() {

			myClass.showMsg ();

			Console.WriteLine ("Static Value: " + myClass.val);

		}

	}


}
