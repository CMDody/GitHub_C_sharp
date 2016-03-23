using System;
using System.Runtime.InteropServices;

namespace RefOutDemo {

	class Test {

		int i, j;

		//...

		public Test(int i, int j) {
			this.i = i;
			this.j = j;

			Console.Write ("Values=[{0}, {1}] ", i, j);

			if (i != j)  // Not single value or zero value...
				Console.WriteLine ("Two independent value Construction. ");
		}

		public Test () : this (0, 0) {
			// this constructor refers to upper first constructor
			// After executing the upper first constructor, 
			// This code below will be executed respectively.
			Console.WriteLine ("Zero Value Construction. ");
		}

		public Test(int a) : this(a, a) {
			// this constructor refers to upper first constructor
			// After executing the upper first constructor,
			// This code below will be executed respectively.
			Console.WriteLine ("Single Value Construction. ");
		}

		//___________________________


		public void show(string name) {
			Console.WriteLine ("Object:{0} ---> i={1}, j={2}", name, i, j);

		}

		//_________using 'ref' for values_____________________

		public void swap(ref int a, ref int b) {

			int tmp;

			tmp = a;
			a = b;
			b = tmp;

		}
			

		public void square(ref int a) {
			a = (a * a);
		}

		//________using 'out' for values__________________________

		public void squareRoot(int a, out double b) {
			b = Math.Sqrt ((double) a);
		}
			

		public void radian(int deg, out double rad) {

			rad = (double)deg;

			rad *= (Math.PI / 180);

		}

		//_______using 'ref' and 'out' for values_________________

		public void swap(ref int a, ref int b, out double ratio) {
			// overloading method, using 'ref' and 'out' together

			int tmp;

			tmp = a;
			a = b;
			b = tmp;

			ratio = (((double)a) / ((double)b));

		}

		//_________using 'ref' for objects______________________

		public void swapObjects(ref Test ob1, ref Test ob2) {

			Test tmp;

			tmp = ob1;
			ob1 = ob2;
			ob2 = tmp;

		}

		//________using 'out' for objects_______________________

		public void incrementObject(Test ob1, out Test ob2) {

			Test tmp;

			tmp = new Test (ob1.i, ob1.j);
			tmp.i *= 10;
			tmp.j *= 30;

			ob2 = tmp;

		}

		//______using 'ref' and 'out' for objects________________

		public void swapAndSum(ref Test ob1, ref Test ob2, out Test ob3) {

			Test tmp;

			tmp = ob1;
			ob1 = ob2;
			ob2 = tmp;

			ob3 = new Test ((ob1.i + ob2.i), (ob1.j + ob2.j));

		}


	}

	//===============================================================================

	class MainClass {

		static void Main() {

			Test obA = new Test ();
			Test obB = new Test (6);
			Test obC = new Test (3, 4);

			Console.WriteLine ("---------------------------------------------------------");

			obA.show ("A");
			obB.show ("B");
			obC.show ("C");

			Console.WriteLine ("---------------------------------------------------------");

			int a = 32;
			int b = 43;

			Console.Write ("Values BEFORE calling swap() method ---> ");
			Console.WriteLine ("A={0}, B={1}", a, b);

			obA.swap (ref a, ref b);

			Console.Write ("Values AFTER calling swap() method ---> ");
			Console.WriteLine ("A={0}, B={1}", a, b);

			Console.WriteLine ("---------------------------------------------------------");

			Console.Write ("Value BEFORE calling square() method ---> ");
			Console.WriteLine ("A={0} ", a);

			obA.square (ref a);

			Console.Write ("Values AFTER calling square() method ---> ");
			Console.WriteLine ("A={0} ", a);

			Console.WriteLine ("---------------------------------------------------------");

			double result;   // No initial value assigned...

			Console.Write ("Value BEFORE calling squareRoot() method ---> ");
			Console.WriteLine ("B={0} ", b);

			obA.squareRoot (b, out result);

			Console.Write ("Values AFTER calling squareRoot() method ---> ");
			Console.WriteLine ("Result={0:F} ", result);

			Console.WriteLine ("---------------------------------------------------------");

			double radian;   // No initial value assigned...

			Console.Write ("Value BEFORE calling radian() method ---> ");
			Console.WriteLine ("B={0} ", b);

			obA.radian (b, out radian);

			Console.Write ("Values AFTER calling radian() method ---> ");
			Console.WriteLine ("Result={0:F} ", radian);

			Console.WriteLine ("---------------------------------------------------------");

			double rate;   // No initial value assigned...

			Console.Write ("Values BEFORE calling swap() method ---> ");
			Console.WriteLine ("A={0}, B={1}", a, b);

			obA.swap (ref a, ref b, out rate);

			Console.Write ("Values AFTER calling swap() method ---> ");
			Console.WriteLine ("A={0}, B={1}, Ratio={2:E2}", a, b, rate);

			Console.WriteLine ("---------------------------------------------------------");

			Console.WriteLine ("Objects BEFORE swapObject() method called");
			obB.show ("B");
			obC.show ("C");

			obA.swapObjects (ref obB, ref obC);

			Console.WriteLine ("Objects AFTER swapObject() method called");
			obB.show ("B");
			obC.show ("C");

			Console.WriteLine ("---------------------------------------------------------");

			Console.WriteLine ("Objects BEFORE incrementObject() method called");
			obB.show ("B");
			obC.show ("C");

			obA.incrementObject (obB, out obC);

			Console.WriteLine ("Objects AFTER incrementObject() method called");
			obB.show ("B");
			obC.show ("C");

			Console.WriteLine ("---------------------------------------------------------");

			Test sum;  // object is not initialized...

			Console.WriteLine ("Objects BEFORE incrementObject() method called");
			obB.show ("B");
			obC.show ("C");

			obA.swapAndSum (ref obB, ref obC, out sum);

			Console.WriteLine ("Objects AFTER incrementObject() method called");
			obB.show ("B");
			obC.show ("C");
			sum.show ("SUM");



		}

	}


}
