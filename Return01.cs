using System;
using System.Security.Principal;


namespace ReturnArrayObject {


	class Test {

		int i;
		int[] array;

		public Test(int i) {
			this.i = i;
			array = new int[i];

			Console.WriteLine ("Size of Array={0}", i);
		}

		public Test():this(10) {
			Console.WriteLine ("Default size construction.");
		}

		//....

		public void setValue(int val, int index) {

			if ((index < i) && (index>=0)) {
				array [index] = val;
			}

		}

		public int getValue(int index) {

			if ((index < i) && (index>=0)) {
				return array [index];
			} else {
				return 0;
			}
		}

		public void autoSetValue() {

			for (int a = 0; a < i; a++) {
				array [a] = (2 * a + 1);
			}

		}

		public void showArray(string name) {

			Console.Write ("Array:{0} -->> ", name);

			foreach(int u in array) {
				Console.Write ("{0}, ", u);
			}

			Console.WriteLine ("END!");

		}

		public int[] getArray() {  // returns array...
			return array;
		}

		public Test getObject() {  // returns object...
			return this;
		}

	}

	//==================================

	class mainClass {

		static void Main() {

			Test obA = new Test ();
			Test obB = new Test (32);
			Test obC;  // not initialized;

			obA.autoSetValue ();
			obB.autoSetValue ();

			obA.showArray ("A");
			obB.showArray ("B");

			obC = obA.getObject ();
			obC.showArray ("C");

			int sum = 0;
			int[] vals = obB.getArray ();
			foreach (int k in vals) {
				sum += k;
			}
			Console.WriteLine ("Sum of array B ---> {0}", sum);

		}

	}

}
